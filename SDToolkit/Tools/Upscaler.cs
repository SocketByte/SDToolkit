using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDToolkit
{
    class Upscaler
    {
        public static void Upscale(Generator.GeneratorConfig config, string[] images)
        {
            var outputNames = new string[images.Length];
            for (var i = 0; i < images.Length; i++)
            {
                outputNames[i] = DateTimeOffset.Now.ToUnixTimeSeconds().ToString() + "_" + i + ".png";
            }
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    WorkingDirectory = Generator.WorkingDirectory,
                },
                EnableRaisingEvents = true,
            };

            process.Exited += (s, e) =>
            {
                if (config.GenerateButton.InvokeRequired)
                {
                    config.GenerateButton.Invoke(new MethodInvoker(delegate ()
                    {
                        for (var i = 0; i < images.Length; i++)
                        {
                            var pictureBox = config.PictureBoxes[i];
                            pictureBox.Image = Image.FromFile("video2x\\outputs\\" + outputNames[i]);
                        }
                        config.GenerateButton.Text = "Generate";

                        config.GenerateButton.Enabled = true;
  
                        config.DebugTextBox.Clear();
                        config.ProgressBar.Value = 0;
                    }));
                }
            };

            process.OutputDataReceived += (s, e) =>
            {
                Generator.PrintToDebug(config.DebugTextBox, e.Data);
            };
            process.ErrorDataReceived += (s, e) =>
            {
                Generator.PrintToDebug(config.DebugTextBox, e.Data);
            };
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();

            using (var sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("cd video2x");
                    for (var i = 0; i < images.Length; i++)
                    {
                        var scale = config.UseGFPGANandVideo2x ? config.Upscale / 2 : config.Upscale;
                        var res = config.ResHeight * scale;
                        
                        var image = images[i];
                        sw.WriteLine(".\\video2x.exe -i \"" + image + "\""
                            + " -o outputs\\" + outputNames[i] 
                            + " -h " + res
                            + " -w " + res
                            + " -d realsr_ncnn_vulkan"
                            + " -p 3");
                    }
                }
            }
        }
    }
}
