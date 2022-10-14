
using NvAPIWrapper.Display;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDToolkit
{
    public partial class Window : Form
    {
        private uint _vram = 0;
        private DateTime _start;
        public Window()
        {
            InitializeComponent();

            var gpus = NvAPIWrapper.GPU.PhysicalGPU.GetPhysicalGPUs();
            var gpu = gpus[0];

            var vramInGb = gpu.MemoryInformation.DedicatedVideoMemoryInkB / 1024 / 1024;
            
            gpuInfoLabel.Text = gpu.FullName + " / " + gpu.MemoryInformation.RAMType + " / " + vramInGb + " GB VRAM";

            _vram = vramInGb;

            if (gpu.FullName.Contains("RTX"))
            {
                precisionCheck.Checked = false;
            } else
            {
                precisionCheck.Checked = true;
            }
           
        } 

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _start = DateTime.Now;

                new Thread(() =>
                {
                    while (!GenerateButton.Enabled)
                    {
                        timerLabel.Invoke(new MethodInvoker(delegate ()
                        {
                            var now = DateTime.Now - _start;
                            var minutes = now.Minutes < 10 ? "0" + now.Minutes : now.Minutes.ToString();
                            var seconds = now.Seconds < 10 ? "0" + now.Seconds : now.Seconds.ToString();
                            timerLabel.Text = minutes + ":" + seconds;
                        }));
                        Thread.Sleep(1000);
                    }
                }).Start();

                GenerateButton.Enabled = false;
                Generator.GenerateFromPrompt(new Generator.GeneratorConfig
                {
                    Prompt = promptBox.Text,
                    ResHeight = int.Parse(resHBox.Text),
                    ResWidth = int.Parse(resWBox.Text),
                    Seed = int.Parse(seedBox.Text),
                    Steps = int.Parse(stepsBox.Text),
                    Precision = precisionCheck.Checked ? "full" : "autocast",

                    Sampler = samplerCombo.Text,

                    UseContextImage = contextImage.Image != null,
                    ContextImage = contextImage.ImageLocation,

                    UseTurbo = _vram >= 32,

                    Upscale = int.Parse(upscaleCombo.Text.Replace("x", "")),

                    DebugTextBox = debugBox,
                    ProgressBar = progressBar,
                    GenerateButton = GenerateButton,
                    PictureBoxes = new PictureBox[]
                    {
                        pictureBox0,
                        pictureBox1,
                        pictureBox2,
                        pictureBox3,
                        pictureBox4,
                        pictureBox5,
                        pictureBox6,
                        pictureBox7
                    },

                    UseGFPGAN = useGFPGAN.Checked,
                    UseGFPGANandVideo2x = false,
                });
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Maximize(int id)
        {
            var pictureBoxes = new PictureBox[]
                {
                    pictureBox0,
                    pictureBox1,
                    pictureBox2,
                    pictureBox3,
                    pictureBox4,
                    pictureBox5,
                    pictureBox6,
                    pictureBox7,
                };

            if (pictureBoxes[id].Dock == DockStyle.None)
            {
                for (var i = 0; i < pictureBoxes.Length; i++)
                {
                    if (i == id)
                    {
                        pictureBoxes[i].Dock = DockStyle.Fill;
                        continue;
                    }
                    pictureBoxes[i].Dock = DockStyle.None;
                    pictureBoxes[i].Hide();
                }
            } 
            else
            {
                for (var i = 0; i < pictureBoxes.Length; i++)
                {
                    if (i == id)
                    {
                        pictureBoxes[i].Dock = DockStyle.None;
                        continue;
                    }
                    pictureBoxes[i].Dock = DockStyle.None;
                    pictureBoxes[i].Show();
                }
            }
        }

        private void pictureBox0_Click(object sender, EventArgs e)
        {
            Maximize(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Maximize(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Maximize(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Maximize(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Maximize(4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Maximize(5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Maximize(6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Maximize(7);
        }

        private void contextButton_Click(object sender, EventArgs e)
        {
            // Open file selectors
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select a context image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;
                contextImage.Image = Image.FromFile(path);
                contextImage.ImageLocation = path;
                
                contextButton.Enabled = false;

                samplerCombo.Enabled = false;
                samplerCombo.SelectedIndex = 0;

                contextRemoveButton.Enabled = true;
            }
        }

        private void contextRemoveButton_Click(object sender, EventArgs e)
        {
            contextImage.Image = null;
            contextImage.ImageLocation = null;

            contextButton.Enabled = true;

            samplerCombo.Enabled = true;
            samplerCombo.SelectedIndex = 1;

            contextRemoveButton.Enabled = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void SetUpscaleInfo()
        {
            var upscaleValue = int.Parse(upscaleCombo.Text.Replace("x", ""));
            var x = upscaleValue * int.Parse(resWBox.Text);
            var y = upscaleValue * int.Parse(resHBox.Text);
            var upscaler = useGFPGAN.Checked ? "GFPGAN" : "Video2x (RealSR)";
            upscaleLabel.Text = "Final image resolution after upscaling: " + x + " x " + y + ", upscaler: " + upscaler;
        }

        private void Window_Load(object sender, EventArgs e)
        {
            SetUpscaleInfo();
        }

        private void upscaleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUpscaleInfo();
        }

        private void resHBox_TextChanged(object sender, EventArgs e)
        {
            SetUpscaleInfo();
        }

        private void resWBox_TextChanged(object sender, EventArgs e)
        {
            SetUpscaleInfo();
        }

        private void useGFPGAN_CheckedChanged(object sender, EventArgs e)
        {
            SetUpscaleInfo();
  
  
        }
    }

    
}
