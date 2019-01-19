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
using YoutubeExplode.Exceptions;
using YoutubeExplode.Internal;
using YoutubeExplode.Internal.Parsers;
using YoutubeExplode.Models.MediaStreams;

namespace BeanDownloader2
{
    public partial class BeanForm : Form
    {
        string videoTitle = "", videoAuthor = "", videoDesc = "", videoID = "";

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBoxStatistics.Visible = true;
            } else
            {
                groupBoxStatistics.Visible = false;
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            buttonDownload.Enabled = false;
            buttonDownload.Text = "DOWNLOAD?";
            var path = "Downloads\\" + videoTitle + (radioButtonAudio.Checked ? ".mp3" : ".mp4");
            DownloadForm dl = new DownloadForm(videoID, path);
            dl.Show();
            buttonDownload.Enabled = true;
            buttonDownload.Text = "DOWNLOAD!!!";
        }

        public BeanForm()
        {
            InitializeComponent();
            labelViewCount.Text = "";
            labelLikeCount.Text = "";
            labelDislikeCount.Text = "";
            labelKeywords.Text = "";
        }

        private async void txtboxURL_TextChangedAsync(object sender, EventArgs e)
        {
            if (txtboxURL.Text == "")
            {

            } else
            {
                labelVideoTitle.Text = "Loading...";
                labelVideoAuthor.Text = "";
                labelDuration.Text = ""; 
                txtboxVideoDesc.Clear();
                var ytClient = new YoutubeClient();
                try
                {
                    videoID = YoutubeClient.ParseVideoId(txtboxURL.Text);
                    var video = await ytClient.GetVideoAsync(videoID);
                    picboxThumbnail.Load(video.Thumbnails.MediumResUrl);
                    Console.WriteLine(video.Thumbnails.MediumResUrl);
                    videoTitle = labelVideoTitle.Text = video.Title;
                    videoAuthor = labelVideoAuthor.Text = video.Author;
                    videoDesc = txtboxVideoDesc.Text = video.Description;
                    labelDuration.Text = video.Duration.ToString();
                    labelViewCount.Text = String.Format("{0:n0}", video.Statistics.ViewCount);
                    labelLikeCount.Text = String.Format("{0:n0}", video.Statistics.LikeCount);
                    labelDislikeCount.Text = String.Format("{0:n0}", video.Statistics.DislikeCount);
                    progressBarLikeRatio.Value = (int)(video.Statistics.AverageRating * 100);
                    labelKeywords.Text = String.Join(", ", video.Keywords);
                    buttonDownload.Enabled = true;
                    buttonDownload.Text = "DOWNLOAD!!!";
                }
                catch (Exception exception)
                {
                    labelVideoTitle.Text = "Error";
                    txtboxVideoDesc.Text = exception.Message.ToString();
                    buttonDownload.Enabled = false;
                    buttonDownload.Text = "DOWNLOAD?";
                }
            }
        }
    }
}
