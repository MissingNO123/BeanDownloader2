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
using YoutubeExplode.Exceptions;
using YoutubeExplode.Internal;
using YoutubeExplode.Internal.Parsers;

namespace BeanDownloader2
{
    public partial class Form1 : Form
    { 
        string videoTitle = "", videoAuthor = "", videoDesc = "";
        public Form1()
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
                    var video = await ytClient.GetVideoAsync(YoutubeClient.ParseVideoId(txtboxURL.Text));
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

                }
                catch (Exception exception)
                {
                    labelVideoTitle.Text = "Error";
                    txtboxVideoDesc.Text = exception.Message.ToString();

                }
            }
        }
    }
}
