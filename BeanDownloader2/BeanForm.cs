using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Exceptions;
using YoutubeExplode.Internal;
//using YoutubeExplode.Internal.Parsers;
//using YoutubeExplode.Models.MediaStreams;

namespace BeanDownloader2
{
    public partial class BeanForm : Form
    {
        string videoTitle = "", videoAuthor = "", videoDesc = "", videoID = "";
        string [] audioFormats = {".mp3", ".flac"};
        string [] videoFormats = {".mp4", ".webm"};

        private void StatsCBToggle(object sender, EventArgs e)
        {
            if (checkBoxStats.Checked == true)
            {
                groupBoxStatistics.Visible = true;
            } else
            {
                groupBoxStatistics.Visible = false;
            }
        }

        private void buttonOpenDownloads_Click(object sender, EventArgs e)
        {
            Process.Start(@".\Downloads");
        }

        private void radioButtonAudio_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFormat.DataSource = radioButtonAudio.Checked ? audioFormats : videoFormats;
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            var safeVideoTitle = Regex.Replace(videoTitle, "[\\\\<>:\"/\\|\\?\\*]", "_", RegexOptions.IgnoreCase);
            safeVideoTitle = Regex.Replace(safeVideoTitle, @"^(CON)$|^(PRN)$|^(AUX)$|^(NUL)$|^(COM\d)$|^(LPT\d)$", "$&_", RegexOptions.IgnoreCase);
            buttonDownload.Enabled = false;
            buttonDownload.Text = "DOWNLOAD?";

            var path = "Downloads\\" + safeVideoTitle + 
                (radioButtonAudio.Checked ? audioFormats[comboBoxFormat.SelectedIndex] : videoFormats[comboBoxFormat.SelectedIndex]);
            DownloadForm dl = new DownloadForm(videoID, path);
            dl.ShowDialog();
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
            comboBoxFormat.DataSource = audioFormats;
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
                    //videoID = YoutubeClient.ParseVideoId(txtboxURL.Text);
                    var video = await ytClient.Videos.GetAsync(txtboxURL.Text);
                    videoID = video.Id;
                    picboxThumbnail.Load(video.Thumbnails.MediumResUrl);
                    //Console.WriteLine(video.Thumbnails.MediumResUrl);
                    videoTitle = labelVideoTitle.Text = video.Title;
                    videoAuthor = labelVideoAuthor.Text = video.Author;
                    videoDesc = txtboxVideoDesc.Text = video.Description;
                    labelDuration.Text = video.Duration.ToString();
                    labelViewCount.Text = String.Format("{0:n0}", video.Engagement.ViewCount);
                    labelLikeCount.Text = String.Format("{0:n0}", video.Engagement.LikeCount);
                    labelDislikeCount.Text = String.Format("{0:n0}", video.Engagement.DislikeCount);
                    progressBarLikeRatio.Value = (int)(video.Engagement.AverageRating * 100);
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
