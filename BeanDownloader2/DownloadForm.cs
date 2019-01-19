using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace BeanDownloader2
{
    public partial class DownloadForm : Form
    {
        string videoID, path;
        public DownloadForm(string vid, string p)
        {
            InitializeComponent();
            videoID = vid;
            path = p;
            downloadVideo();
        }
        private async void downloadVideo()
        { 
            try
            {
                var ytConverter = new YoutubeConverter();


                //await ytConverter.DownloadVideoAsync(videoID, path, progressIndicator);
                Progress<double> progressd = new Progress<double>();
                progressd.ProgressChanged += ReportProgress;
                await ytConverter.DownloadVideoAsync(videoID, path, progressd, default(System.Threading.CancellationToken));
                MessageBox.Show("Finished Downloading " + path, "Succ", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error downloading: " + exception.Message);
                Console.WriteLine("Exception: \n" + exception.Data);
            }
        }

        private void ReportProgress(object sender, double e)
        {
            progressBarDownload.Value = (int)(e * 100);
            labelPercent.Text = String.Format("{0:P2}", e);
        }
    }
}
