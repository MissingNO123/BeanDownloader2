using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading; 
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace BeanDownloader2
{
    public partial class DownloadForm : Form
    {
        CancellationTokenSource cts = new CancellationTokenSource(); 
        string videoID, path;
        public DownloadForm(string vid, string p)
        {
            InitializeComponent();
            videoID = vid;
            path = p;
            DownloadVideo();
        }
        private async void DownloadVideo()
        { 
            try
            {
                var ytConverter = new YoutubeConverter();
                CancellationToken token = cts.Token; 
                //await ytConverter.DownloadVideoAsync(videoID, path, progressIndicator);
                Progress<double> progressd = new Progress<double>();
                progressd.ProgressChanged += ReportProgress;
                await ytConverter.DownloadVideoAsync(videoID, path, progressd, token);
                notifyIconDownload.BalloonTipText = ("Finished Downloading " + path).Truncate(63);
                notifyIconDownload.ShowBalloonTip(5000);
                //MessageBox.Show("Finished Downloading " + path, "Succ", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception exception)
            {
                if (exception.Message != "A task was canceled." && exception.Message != "The operation was canceled.")
                { 
                    MessageBox.Show("Error downloading: " + exception.Message); 
                }
                Console.WriteLine("Exception: \n" + exception.Data);
            }
        }

        private void DownloadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Request cancellation.
            cts.Cancel();
            Console.WriteLine("Cancellation set in token source...");
            Thread.Sleep(2500);
            // Cancellation should have happened, so call Dispose.
            cts.Dispose();
            notifyIconDownload.Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportProgress(object sender, double e)
        {
            progressBarDownload.Value = (int)(e * 100);
            labelPercent.Text = String.Format("{0:P2}", e);
        }
    }
}
