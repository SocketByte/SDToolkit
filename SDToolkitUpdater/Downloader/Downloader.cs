using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDToolkitUpdater.Downloader
{
    internal class Downloader
    {
        public static async Task DownloadAsync(ProgressBar progressBar, Label progressLabel, Label updateLabel, string address, int fileSize)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Automatic;
            
            HttpClient client = new HttpClient(handler);
            client.DefaultRequestHeaders.ExpectContinue = false;
            
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, address);
            HttpResponseMessage response = await client.SendAsync(message,
                HttpCompletionOption.ResponseHeadersRead);
            
            var stream = await response.Content.ReadAsStreamAsync();
            var memStream = new MemoryStream();

            var res = stream.CopyToAsync(memStream);
            var timer = new Stopwatch();
            timer.Start();

            while (true)
            {

                var streamInKb = memStream.Length / 1024.0;
                var progress = 100.0 * ((double)streamInKb / (double)fileSize);
                Console.WriteLine(progress + " : " + streamInKb / 1024 + " : " + fileSize / 1024);

                progressBar.Invoke(new MethodInvoker(delegate ()
                {
                    if (progress < 100)
                    {
                        progressBar.Value = (int)progress;
                        progressLabel.Text = (int)progress + "%";

                        if (timer.ElapsedMilliseconds >= 1000)
                        {
                            timer.Restart();
                            updateLabel.Text = "Downloading... " + Math.Round(streamInKb / 1024.0) + " / " + Math.Round(fileSize / 1024.0) + " MB";
                        }
                    } 
                    else
                    {
                        progressBar.Value = 100;
                        progressLabel.Text = "100%";
       
                    }
                }));

                if (res.IsCompleted)
                {
                    break;
                }
            }

            byte[] responseContent = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(responseContent, 0, responseContent.Length);

            using (FileStream fileStream = new FileStream("patch.zip", FileMode.Create, FileAccess.Write))
            {
                fileStream.Write(responseContent, 0, responseContent.Length);
            }
        }
    }
}
