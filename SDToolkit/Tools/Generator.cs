using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDToolkit
{
    class Generator
    {
        public static readonly string WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public delegate void OnEnd();

        public class GeneratorConfig
        {
            public string Prompt { get; set; }
            public int ResHeight { get; set; }
            public int ResWidth { get; set; }
            public int Seed { get; set; }
            public int Steps { get; set; }
            public string Precision { get; set; }
            public int Upscale { get; set; }
            public bool UseContextImage { get; set; }

            public string ContextImage { get; set; }

            public bool UseTurbo { get; set; }

            public bool UseGFPGAN { get; set; }

            public bool UseGFPGANandVideo2x { get; set; }

            public string Sampler { get; set; }

            public OnEnd OnEnd { get; set; }

            public TextBox DebugTextBox { get; set; } 
            public ProgressBar ProgressBar { get; set; }
            public Button GenerateButton { get; set; }
            public PictureBox[] PictureBoxes { get; set; }
        }

        public static void PrintToDebug(TextBox debugBox, string message)
        {
            if (message == null)
            {
                return;
            }
            debugBox.Invoke(new MethodInvoker(delegate ()
            {
                if (message.Length <= 0)
                {
                    return;
                }
                debugBox.AppendText(message + "\r\n");
                debugBox.ScrollToCaret();
            }));
        }

        public static void GenerateFromPrompt(GeneratorConfig config)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                Run(config);
            }).Start();
        }

        private static void Run(GeneratorConfig config)
        {
            var samples = config.UseContextImage ? "img2img-samples" : "txt2img-samples";
            var samplesDir = WorkingDirectory + "\\stable-diffusion\\outputs\\" + samples;
            if (Directory.Exists(samplesDir))
            {
                Directory.Delete(samplesDir, true);
            }

            var path = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();

            config.GenerateButton.Invoke(new MethodInvoker(delegate ()
            {
                config.GenerateButton.Text = "Generating...";
            }));

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
                    WorkingDirectory = WorkingDirectory,
                },
                EnableRaisingEvents = true,
            };

            process.Exited += (s, e) =>
            {
                try
                {
                    var prompt = config.Prompt;
                    var converted = string.Join("_", prompt.Split(' '));

                    var dir = Directory.GetDirectories(WorkingDirectory + @"\stable-diffusion\outputs\" + samples)[0];
                    var images = Directory.GetFiles(dir, "*.png");

                    if (config.UseGFPGAN)
                    {
                        config.GenerateButton.Invoke(new MethodInvoker(delegate ()
                        {
                            config.GenerateButton.Text = "Restoring faces and upscaling with GFPGAN...";
                            config.DebugTextBox.Clear();
                        }));
                        FaceRestoration.RestoreWithGFPGAN(config, images);
                        return;
                    }

                    config.GenerateButton.Invoke(new MethodInvoker(delegate ()
                    {
                        config.GenerateButton.Text = "Upscaling with Video2x...";
                        config.DebugTextBox.Clear();
                    }));

                    Upscaler.Upscale(config, images);
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            };

            process.ErrorDataReceived += (s, e) =>
            {
                Console.WriteLine(e.Data);
                PrintToDebug(config.DebugTextBox, e.Data);

                if (e.Data == null)
                {
                    return;
                }
                if (e.Data.Contains("Sampler:") || e.Data.Contains("Decoding image:"))
                {
                    var percentage = e.Data.Split(':')[1].Split('%')[0].Trim();
                    if (percentage.Length == 0)
                    {
                        return;
                    }
                    config.ProgressBar.Invoke(new MethodInvoker(delegate ()
                    {
                        config.ProgressBar.Value = int.Parse(percentage);
                    }));

                    config.GenerateButton.Invoke(new MethodInvoker(delegate ()
                    {
                        config.GenerateButton.Text = "Generating... (" + percentage + "%)";
                    }));
                }
            };

            process.OutputDataReceived += (s, e) =>
            {
                Console.WriteLine(e.Data);
                PrintToDebug(config.DebugTextBox, e.Data);
            };

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();

            using (var sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("conda\\Scripts\\activate.bat");
                    sw.WriteLine("activate ldm");
                    sw.WriteLine("cd stable-diffusion");
                    sw.WriteLine("pip install -e .");
                    sw.WriteLine("pip install taming-transformers-rom1504");
                    sw.WriteLine("pip install clip");
                    if (!config.UseContextImage)
                    {
                        sw.WriteLine("python optimizedSD/optimized_txt2img.py --prompt \"" + config.Prompt + "\""
                        + " --sampler " + config.Sampler.ToLower()
                        + " --H " + config.ResHeight
                        + " --W " + config.ResWidth
                        + " --seed " + config.Seed
                        + (config.UseTurbo ? " --turbo" : "")
                        + " --precision " + config.Precision
                        + " --n_iter 1 --n_samples 8 --ddim_steps " + config.Steps);
                    } 
                    else
                    {
                        sw.WriteLine("python optimizedSD/optimized_img2img.py --strength 0.8 --prompt \"" + config.Prompt + "\""
                        + " --init-img " + config.ContextImage
                        + " --H " + config.ResHeight
                        + " --W " + config.ResWidth
                        + " --seed " + config.Seed
                        + (config.UseTurbo ? " --turbo" : "")
                        + " --precision " + config.Precision
                        + " --n_iter 1 --n_samples 8 --ddim_steps " + config.Steps);
      
                    }
                }
            }
        }
    }
}
