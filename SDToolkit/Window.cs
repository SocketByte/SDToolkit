
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
                precisionCombo.SelectedIndex = 1;
            } else
            {
                precisionCombo.SelectedIndex = 0;
            }
           
        } 

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateButton.Enabled = false;
            Generator.GenerateFromPrompt(new Generator.GeneratorConfig
            {
                Prompt = promptBox.Text,
                ResHeight = int.Parse(resHBox.Text),
                ResWidth = int.Parse(resWBox.Text),
                Seed = int.Parse(seedBox.Text),
                Steps = int.Parse(stepsBox.Text),
                UpscalingAlgorithm = upscalingCombo.Text,
                Precision = precisionCombo.Text,

                UseTurbo = _vram >= 8,

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
                }
            });
        }

        private void pictureBox0_Click(object sender, EventArgs e)
        {
            
        }
    }

    
}
