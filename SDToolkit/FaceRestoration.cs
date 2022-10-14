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
    class FaceRestoration
    {
        public static void RestoreWithGFPGAN(Generator.GeneratorConfig config, string[] images)
        {
            var outputNames = new string[images.Length];
            for (var i = 0; i < images.Length; i++)
            {
                outputNames[i] = DateTimeOffset.Now.ToUnixTimeSeconds().ToString() + "_" + i + ".png";
            }

            var inputs = "GFPGAN\\inputs\\temp";
            if (Directory.Exists(inputs))
            {
                Directory.Delete(inputs, true);
            }
            Directory.CreateDirectory(inputs);
            for (var i = 0; i < images.Length; i++)
            {
                var image = images[i];
                File.Copy(image, inputs + "\\" + outputNames[i]);
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
                        if (config.UseGFPGANandVideo2x)
                        {
                            config.GenerateButton.Invoke(new MethodInvoker(delegate ()
                            {
                                config.GenerateButton.Text = "Upscaling with Video2x...";
                                config.DebugTextBox.Clear();
                            }));

                            Upscaler.Upscale(config, images);
                            return;
                        }

                        for (var i = 0; i < images.Length; i++)
                        {
                            var image = images[i];
                            var pictureBox = config.PictureBoxes[i];
                            pictureBox.Image = Image.FromFile("GFPGAN\\results\\restored_imgs\\" + outputNames[i]);
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
                Console.WriteLine(e.Data);
                Generator.PrintToDebug(config.DebugTextBox, e.Data);
            };
            process.ErrorDataReceived += (s, e) =>
            {
                Console.WriteLine(e.Data);
                Generator.PrintToDebug(config.DebugTextBox, e.Data);
            };
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();

            using (var sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    var scale = config.Upscale;
                    if (config.UseGFPGANandVideo2x)
                    {
                        scale = 2;
                    }
                    sw.WriteLine("conda\\Scripts\\activate.bat");
                    sw.WriteLine("activate");
                    sw.WriteLine("cd GFPGAN");
                    sw.WriteLine("python inference_gfpgan.py -i inputs/temp -o results -v 1.3 -s " + scale);
                }
            }
        }
    }
}
