namespace BeanDownloader2
{
    partial class BeanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeanForm));
            this.txtboxURL = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelVideoTitle = new System.Windows.Forms.Label();
            this.txtboxVideoDesc = new System.Windows.Forms.TextBox();
            this.labelVideoAuthor = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.radioButtonVideo = new System.Windows.Forms.RadioButton();
            this.radioButtonAudio = new System.Windows.Forms.RadioButton();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.labelKeywords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelViewCount = new System.Windows.Forms.Label();
            this.progressBarLikeRatio = new System.Windows.Forms.ProgressBar();
            this.labelDislikes = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelViews = new System.Windows.Forms.Label();
            this.labelLikeCount = new System.Windows.Forms.Label();
            this.labelDislikeCount = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonOpenDownloads = new System.Windows.Forms.Button();
            this.picboxThumbnail = new System.Windows.Forms.PictureBox();
            this.groupBoxStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxURL
            // 
            this.txtboxURL.BackColor = System.Drawing.Color.Black;
            this.txtboxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxURL.ForeColor = System.Drawing.SystemColors.Control;
            this.txtboxURL.Location = new System.Drawing.Point(539, 12);
            this.txtboxURL.Name = "txtboxURL";
            this.txtboxURL.Size = new System.Drawing.Size(251, 20);
            this.txtboxURL.TabIndex = 1;
            this.txtboxURL.TextChanged += new System.EventHandler(this.txtboxURL_TextChangedAsync);
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.ForeColor = System.Drawing.SystemColors.Control;
            this.labelURL.Location = new System.Drawing.Point(501, 15);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(32, 13);
            this.labelURL.TabIndex = 2;
            this.labelURL.Text = "URL:";
            this.labelURL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVideoTitle
            // 
            this.labelVideoTitle.AutoEllipsis = true;
            this.labelVideoTitle.AutoSize = true;
            this.labelVideoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVideoTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVideoTitle.Location = new System.Drawing.Point(7, 285);
            this.labelVideoTitle.MaximumSize = new System.Drawing.Size(480, 25);
            this.labelVideoTitle.Name = "labelVideoTitle";
            this.labelVideoTitle.Size = new System.Drawing.Size(53, 25);
            this.labelVideoTitle.TabIndex = 3;
            this.labelVideoTitle.Text = "Title";
            // 
            // txtboxVideoDesc
            // 
            this.txtboxVideoDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.txtboxVideoDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxVideoDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.txtboxVideoDesc.Location = new System.Drawing.Point(12, 349);
            this.txtboxVideoDesc.Multiline = true;
            this.txtboxVideoDesc.Name = "txtboxVideoDesc";
            this.txtboxVideoDesc.Size = new System.Drawing.Size(473, 205);
            this.txtboxVideoDesc.TabIndex = 4;
            this.txtboxVideoDesc.Text = "Description";
            // 
            // labelVideoAuthor
            // 
            this.labelVideoAuthor.AutoEllipsis = true;
            this.labelVideoAuthor.AutoSize = true;
            this.labelVideoAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVideoAuthor.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVideoAuthor.Location = new System.Drawing.Point(8, 310);
            this.labelVideoAuthor.MaximumSize = new System.Drawing.Size(480, 0);
            this.labelVideoAuthor.Name = "labelVideoAuthor";
            this.labelVideoAuthor.Size = new System.Drawing.Size(57, 20);
            this.labelVideoAuthor.TabIndex = 5;
            this.labelVideoAuthor.Text = "Author";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoEllipsis = true;
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDuration.Location = new System.Drawing.Point(9, 330);
            this.labelDuration.MaximumSize = new System.Drawing.Size(480, 0);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(58, 16);
            this.labelDuration.TabIndex = 5;
            this.labelDuration.Text = "Duration";
            // 
            // radioButtonVideo
            // 
            this.radioButtonVideo.AutoSize = true;
            this.radioButtonVideo.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonVideo.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonVideo.Location = new System.Drawing.Point(603, 40);
            this.radioButtonVideo.Name = "radioButtonVideo";
            this.radioButtonVideo.Size = new System.Drawing.Size(52, 17);
            this.radioButtonVideo.TabIndex = 8;
            this.radioButtonVideo.Text = "Video";
            this.radioButtonVideo.UseVisualStyleBackColor = false;
            // 
            // radioButtonAudio
            // 
            this.radioButtonAudio.AutoSize = true;
            this.radioButtonAudio.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAudio.Checked = true;
            this.radioButtonAudio.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonAudio.Location = new System.Drawing.Point(545, 40);
            this.radioButtonAudio.Name = "radioButtonAudio";
            this.radioButtonAudio.Size = new System.Drawing.Size(52, 17);
            this.radioButtonAudio.TabIndex = 8;
            this.radioButtonAudio.TabStop = true;
            this.radioButtonAudio.Text = "Audio";
            this.radioButtonAudio.UseVisualStyleBackColor = false;
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonDownload.Enabled = false;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDownload.Location = new System.Drawing.Point(504, 67);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(286, 56);
            this.buttonDownload.TabIndex = 10;
            this.buttonDownload.Text = "DOWNLOAD?";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.AutoSize = true;
            this.groupBoxStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxStatistics.Controls.Add(this.labelKeywords);
            this.groupBoxStatistics.Controls.Add(this.label1);
            this.groupBoxStatistics.Controls.Add(this.labelViewCount);
            this.groupBoxStatistics.Controls.Add(this.progressBarLikeRatio);
            this.groupBoxStatistics.Controls.Add(this.labelDislikes);
            this.groupBoxStatistics.Controls.Add(this.labelLikes);
            this.groupBoxStatistics.Controls.Add(this.labelViews);
            this.groupBoxStatistics.Controls.Add(this.labelLikeCount);
            this.groupBoxStatistics.Controls.Add(this.labelDislikeCount);
            this.groupBoxStatistics.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxStatistics.Location = new System.Drawing.Point(504, 163);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(286, 79);
            this.groupBoxStatistics.TabIndex = 11;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistics";
            this.groupBoxStatistics.Visible = false;
            // 
            // labelKeywords
            // 
            this.labelKeywords.AutoEllipsis = true;
            this.labelKeywords.AutoSize = true;
            this.labelKeywords.Location = new System.Drawing.Point(38, 50);
            this.labelKeywords.MaximumSize = new System.Drawing.Size(248, 393);
            this.labelKeywords.Name = "labelKeywords";
            this.labelKeywords.Size = new System.Drawing.Size(31, 13);
            this.labelKeywords.TabIndex = 8;
            this.labelKeywords.Text = "Tags";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tags";
            // 
            // labelViewCount
            // 
            this.labelViewCount.AutoSize = true;
            this.labelViewCount.Location = new System.Drawing.Point(39, 16);
            this.labelViewCount.Name = "labelViewCount";
            this.labelViewCount.Size = new System.Drawing.Size(35, 13);
            this.labelViewCount.TabIndex = 3;
            this.labelViewCount.Text = "label4";
            // 
            // progressBarLikeRatio
            // 
            this.progressBarLikeRatio.Location = new System.Drawing.Point(9, 32);
            this.progressBarLikeRatio.MarqueeAnimationSpeed = 1;
            this.progressBarLikeRatio.Maximum = 500;
            this.progressBarLikeRatio.Name = "progressBarLikeRatio";
            this.progressBarLikeRatio.Size = new System.Drawing.Size(258, 10);
            this.progressBarLikeRatio.Step = 1;
            this.progressBarLikeRatio.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarLikeRatio.TabIndex = 6;
            this.progressBarLikeRatio.Value = 2;
            // 
            // labelDislikes
            // 
            this.labelDislikes.AutoSize = true;
            this.labelDislikes.Location = new System.Drawing.Point(180, 16);
            this.labelDislikes.Name = "labelDislikes";
            this.labelDislikes.Size = new System.Drawing.Size(43, 13);
            this.labelDislikes.TabIndex = 2;
            this.labelDislikes.Text = "Dislikes";
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Location = new System.Drawing.Point(80, 16);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(32, 13);
            this.labelLikes.TabIndex = 1;
            this.labelLikes.Text = "Likes";
            // 
            // labelViews
            // 
            this.labelViews.AutoSize = true;
            this.labelViews.Location = new System.Drawing.Point(6, 16);
            this.labelViews.Name = "labelViews";
            this.labelViews.Size = new System.Drawing.Size(35, 13);
            this.labelViews.TabIndex = 0;
            this.labelViews.Text = "Views";
            // 
            // labelLikeCount
            // 
            this.labelLikeCount.BackColor = System.Drawing.Color.Transparent;
            this.labelLikeCount.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelLikeCount.Location = new System.Drawing.Point(117, 16);
            this.labelLikeCount.Name = "labelLikeCount";
            this.labelLikeCount.Size = new System.Drawing.Size(57, 18);
            this.labelLikeCount.TabIndex = 4;
            this.labelLikeCount.Text = "label5";
            // 
            // labelDislikeCount
            // 
            this.labelDislikeCount.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelDislikeCount.Location = new System.Drawing.Point(229, 16);
            this.labelDislikeCount.Name = "labelDislikeCount";
            this.labelDislikeCount.Size = new System.Drawing.Size(51, 23);
            this.labelDislikeCount.TabIndex = 5;
            this.labelDislikeCount.Text = "label6";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(662, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show Video Statistics";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonOpenDownloads
            // 
            this.buttonOpenDownloads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.buttonOpenDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDownloads.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOpenDownloads.Location = new System.Drawing.Point(504, 130);
            this.buttonOpenDownloads.Name = "buttonOpenDownloads";
            this.buttonOpenDownloads.Size = new System.Drawing.Size(285, 23);
            this.buttonOpenDownloads.TabIndex = 13;
            this.buttonOpenDownloads.Text = "Open Downloads Folder";
            this.buttonOpenDownloads.UseVisualStyleBackColor = false;
            // 
            // picboxThumbnail
            // 
            this.picboxThumbnail.BackColor = System.Drawing.Color.Black;
            this.picboxThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxThumbnail.Location = new System.Drawing.Point(12, 12);
            this.picboxThumbnail.Name = "picboxThumbnail";
            this.picboxThumbnail.Size = new System.Drawing.Size(480, 270);
            this.picboxThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxThumbnail.TabIndex = 0;
            this.picboxThumbnail.TabStop = false;
            // 
            // BeanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(801, 567);
            this.Controls.Add(this.buttonOpenDownloads);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.radioButtonAudio);
            this.Controls.Add(this.radioButtonVideo);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelVideoAuthor);
            this.Controls.Add(this.txtboxVideoDesc);
            this.Controls.Add(this.labelVideoTitle);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.txtboxURL);
            this.Controls.Add(this.picboxThumbnail);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BeanForm";
            this.Text = "Bean";
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxThumbnail;
        private System.Windows.Forms.TextBox txtboxURL;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label labelVideoTitle;
        private System.Windows.Forms.TextBox txtboxVideoDesc;
        private System.Windows.Forms.Label labelVideoAuthor;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.RadioButton radioButtonVideo;
        private System.Windows.Forms.RadioButton radioButtonAudio;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.Label labelDislikeCount;
        private System.Windows.Forms.Label labelLikeCount;
        private System.Windows.Forms.Label labelViewCount;
        private System.Windows.Forms.Label labelDislikes;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelViews;
        private System.Windows.Forms.ProgressBar progressBarLikeRatio;
        private System.Windows.Forms.Label labelKeywords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonOpenDownloads;
    }
}

