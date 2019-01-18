namespace BeanDownloader2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picboxThumbnail = new System.Windows.Forms.PictureBox();
            this.txtboxURL = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelVideoTitle = new System.Windows.Forms.Label();
            this.txtboxVideoDesc = new System.Windows.Forms.TextBox();
            this.labelVideoAuthor = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.comboBoxFormatsList = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelFormat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelViews = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelDislikes = new System.Windows.Forms.Label();
            this.labelViewCount = new System.Windows.Forms.Label();
            this.labelLikeCount = new System.Windows.Forms.Label();
            this.labelDislikeCount = new System.Windows.Forms.Label();
            this.progressBarLikeRatio = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKeywords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxThumbnail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // txtboxURL
            // 
            this.txtboxURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtboxURL.ForeColor = System.Drawing.SystemColors.Control;
            this.txtboxURL.Location = new System.Drawing.Point(546, 12);
            this.txtboxURL.Name = "txtboxURL";
            this.txtboxURL.Size = new System.Drawing.Size(278, 20);
            this.txtboxURL.TabIndex = 1;
            this.txtboxURL.TextChanged += new System.EventHandler(this.txtboxURL_TextChangedAsync);
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.ForeColor = System.Drawing.SystemColors.Control;
            this.labelURL.Location = new System.Drawing.Point(508, 15);
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
            this.txtboxVideoDesc.BackColor = System.Drawing.Color.Black;
            this.txtboxVideoDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxVideoDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.txtboxVideoDesc.Location = new System.Drawing.Point(12, 349);
            this.txtboxVideoDesc.Multiline = true;
            this.txtboxVideoDesc.Name = "txtboxVideoDesc";
            this.txtboxVideoDesc.Size = new System.Drawing.Size(473, 245);
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
            // comboBoxFormatsList
            // 
            this.comboBoxFormatsList.BackColor = System.Drawing.Color.Black;
            this.comboBoxFormatsList.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxFormatsList.FormattingEnabled = true;
            this.comboBoxFormatsList.Location = new System.Drawing.Point(662, 37);
            this.comboBoxFormatsList.Name = "comboBoxFormatsList";
            this.comboBoxFormatsList.Size = new System.Drawing.Size(162, 21);
            this.comboBoxFormatsList.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Location = new System.Drawing.Point(604, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Video";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Checked = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton2.Location = new System.Drawing.Point(546, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Audio";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFormat.Location = new System.Drawing.Point(501, 40);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(42, 13);
            this.labelFormat.TabIndex = 9;
            this.labelFormat.Text = "Format:";
            this.labelFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(504, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "DOWNLOAD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.labelKeywords);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelViewCount);
            this.groupBox1.Controls.Add(this.progressBarLikeRatio);
            this.groupBox1.Controls.Add(this.labelDislikes);
            this.groupBox1.Controls.Add(this.labelLikes);
            this.groupBox1.Controls.Add(this.labelViews);
            this.groupBox1.Controls.Add(this.labelLikeCount);
            this.groupBox1.Controls.Add(this.labelDislikeCount);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(504, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 79);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
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
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Location = new System.Drawing.Point(80, 16);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(32, 13);
            this.labelLikes.TabIndex = 1;
            this.labelLikes.Text = "Likes";
            // 
            // labelDislikes
            // 
            this.labelDislikes.AutoSize = true;
            this.labelDislikes.Location = new System.Drawing.Point(194, 16);
            this.labelDislikes.Name = "labelDislikes";
            this.labelDislikes.Size = new System.Drawing.Size(43, 13);
            this.labelDislikes.TabIndex = 2;
            this.labelDislikes.Text = "Dislikes";
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
            // labelLikeCount
            // 
            this.labelLikeCount.BackColor = System.Drawing.Color.Transparent;
            this.labelLikeCount.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelLikeCount.Location = new System.Drawing.Point(117, 16);
            this.labelLikeCount.Name = "labelLikeCount";
            this.labelLikeCount.Size = new System.Drawing.Size(71, 18);
            this.labelLikeCount.TabIndex = 4;
            this.labelLikeCount.Text = "label5";
            // 
            // labelDislikeCount
            // 
            this.labelDislikeCount.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelDislikeCount.Location = new System.Drawing.Point(243, 16);
            this.labelDislikeCount.Name = "labelDislikeCount";
            this.labelDislikeCount.Size = new System.Drawing.Size(71, 23);
            this.labelDislikeCount.TabIndex = 5;
            this.labelDislikeCount.Text = "label6";
            // 
            // progressBarLikeRatio
            // 
            this.progressBarLikeRatio.Location = new System.Drawing.Point(9, 32);
            this.progressBarLikeRatio.MarqueeAnimationSpeed = 1;
            this.progressBarLikeRatio.Maximum = 500;
            this.progressBarLikeRatio.Name = "progressBarLikeRatio";
            this.progressBarLikeRatio.Size = new System.Drawing.Size(304, 10);
            this.progressBarLikeRatio.Step = 1;
            this.progressBarLikeRatio.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarLikeRatio.TabIndex = 6;
            this.progressBarLikeRatio.Value = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(836, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBoxFormatsList);
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
            this.Name = "Form1";
            this.Text = "Bean";
            ((System.ComponentModel.ISupportInitialize)(this.picboxThumbnail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxFormatsList;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDislikeCount;
        private System.Windows.Forms.Label labelLikeCount;
        private System.Windows.Forms.Label labelViewCount;
        private System.Windows.Forms.Label labelDislikes;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelViews;
        private System.Windows.Forms.ProgressBar progressBarLikeRatio;
        private System.Windows.Forms.Label labelKeywords;
        private System.Windows.Forms.Label label1;
    }
}

