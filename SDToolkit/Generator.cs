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

        public class GeneratorConfig
        {
            public string Prompt { get; set; }
            public int ResHeight { get; set; }
            public int ResWidth { get; set; }
            public int Seed { get; set; }
            public int Steps { get; set; }
            public string UpscalingAlgorithm { get; set; }
            public string Precision { get; set; }

            public bool UseTurbo { get; set; }

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
            Directory.Delete(WorkingDirectory + "\\stable-diffusion\\outputs\\txt2img-samples", true);

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
                var prompt = config.Prompt;
                var converted = string.Join("_", prompt.Split(' '));

                var images = Directory.GetFiles(WorkingDirectory + @"\stable-diffusion\outputs\txt2img-samples\" + converted, "*.png");

                config.GenerateButton.Invoke(new MethodInvoker(delegate ()
                {
                    config.GenerateButton.Text = "Upscaling...";
                    config.DebugTextBox.Clear();
                }));

                Upscaler.Upscale(config, images);
            };

            process.ErrorDataReceived += (s, e) =>
            {
                if (e.Data == null)
                {
                    return;
                }
                if (e.Data.Contains("PLMS Sampler:"))
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
                    sw.WriteLine("python optimizedSD/optimized_txt2img.py --prompt \"" + config.Prompt + "\""
                        + " --H " + config.ResHeight
                        + " --W " + config.ResWidth
                        + " --seed " + config.Seed
                        + (config.UseTurbo ? " --turbo" : "")
                        + (config.Precision == "Full" ? " --precision full" : "")
                        + " --n_iter 1 --n_samples 8 --ddim_steps " + config.Steps);
                }
            }
        }
    }
}
