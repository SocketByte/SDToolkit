using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDToolkitUpdater
{
    public partial class Window : Form
    {
        private string _patchUrl;
        private int _patchSize;

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            var client = new RestClient("https://api.github.com/repos/SocketByte/SDToolkit/releases");
            var request = new RestRequest();
            request.AddHeader("Accept", "application/vnd.github+json");
            RestResponse response = client.Execute(request);

            var releases = JArray.Parse(response.Content);
            var asset = releases[0]["assets"][0];
            _patchUrl = asset["browser_download_url"].ToString();
            _patchSize = int.Parse(asset["size"].ToString());
        }

        private void Window_Shown(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(async () =>
            {
                if (File.Exists("patch.zip"))
                {
                    File.Delete("patch.zip");
                }

                await Downloader.Downloader.DownloadAsync(
                    downloadBar, downloadLabel, updateLabel,
                    _patchUrl, _patchSize / 1024);

                if (Directory.Exists("patch"))
                {
                    Directory.Delete("patch", true);
                }
                
                ZipFile.ExtractToDirectory("patch.zip", "patch");

                var files = Directory.GetFiles("patch", "*.*", SearchOption.AllDirectories);
                var total = files.Length;
                var current = 1;
                foreach (var file in files)
                {
                    var dest = file.Replace("patch\\", "");
                    if (Path.GetDirectoryName(dest) == String.Empty || Directory.Exists(Path.GetDirectoryName(dest)))
                    {
                        File.Copy(file, dest, true);
                    }
                    else
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(dest));
                        File.Copy(file, dest, true);
                    }

                    Console.WriteLine(dest);
                    var progress = (int)Math.Round(100.0 * ((double)total / (double)current));
                    installBar.Invoke(new MethodInvoker(delegate ()
                    {
                        if (progress < 100)
                        {
                            installBar.Value = progress;
                            installLabel.Text = progress.ToString() + "%";
                        }
                        else
                        {
                            installBar.Value = 100;
                            installLabel.Text = "100%";
                        }
                        updateLabel.Text = "Installing... " + current + " / " + total;
                    }));
                    current++;
                }
                
                Directory.Delete("patch", true);
                File.Delete("patch.zip");

                var process = new Process();
                process.StartInfo.FileName = "SDToolkit.exe";
                process.Start();

                Environment.Exit(0);
            });

            thread.Start();
        }
    }
}
