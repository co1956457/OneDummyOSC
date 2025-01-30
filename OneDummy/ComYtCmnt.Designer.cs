namespace OneDummy
{
    partial class ComYtCmnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComYtCmnt));
            this.labelOSC = new System.Windows.Forms.Label();
            this.buttonYouTubeCommentOSC = new System.Windows.Forms.Button();
            this.labelCommonAPI = new System.Windows.Forms.Label();
            this.labelOscAddress = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxTimestamp = new System.Windows.Forms.TextBox();
            this.textBoxIconUrl = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelTimestamp = new System.Windows.Forms.Label();
            this.labelIconUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOSC
            // 
            this.labelOSC.AutoSize = true;
            this.labelOSC.ForeColor = System.Drawing.Color.White;
            this.labelOSC.Location = new System.Drawing.Point(73, 56);
            this.labelOSC.Name = "labelOSC";
            this.labelOSC.Size = new System.Drawing.Size(48, 30);
            this.labelOSC.TabIndex = 999;
            this.labelOSC.Text = "🍣:\r\n";
            this.labelOSC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonYouTubeCommentOSC
            // 
            this.buttonYouTubeCommentOSC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYouTubeCommentOSC.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonYouTubeCommentOSC.Location = new System.Drawing.Point(117, 53);
            this.buttonYouTubeCommentOSC.Name = "buttonYouTubeCommentOSC";
            this.buttonYouTubeCommentOSC.Size = new System.Drawing.Size(260, 41);
            this.buttonYouTubeCommentOSC.TabIndex = 1;
            this.buttonYouTubeCommentOSC.Text = "➤VirtualCast";
            this.buttonYouTubeCommentOSC.UseVisualStyleBackColor = true;
            this.buttonYouTubeCommentOSC.Click += new System.EventHandler(this.buttonYouTubeCommentOSC_Click);
            // 
            // labelCommonAPI
            // 
            this.labelCommonAPI.AutoSize = true;
            this.labelCommonAPI.Location = new System.Drawing.Point(2, 2);
            this.labelCommonAPI.Name = "labelCommonAPI";
            this.labelCommonAPI.Size = new System.Drawing.Size(312, 30);
            this.labelCommonAPI.TabIndex = 999;
            this.labelCommonAPI.Text = "●共通受信API [YouTubeコメント]";
            // 
            // labelOscAddress
            // 
            this.labelOscAddress.AutoSize = true;
            this.labelOscAddress.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelOscAddress.Location = new System.Drawing.Point(32, 29);
            this.labelOscAddress.Name = "labelOscAddress";
            this.labelOscAddress.Size = new System.Drawing.Size(250, 21);
            this.labelOscAddress.TabIndex = 999;
            this.labelOscAddress.Text = "/vc-official/onecomme/common";
            // 
            // textBoxType
            // 
            this.textBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxType.ForeColor = System.Drawing.Color.Black;
            this.textBoxType.Location = new System.Drawing.Point(117, 110);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(260, 35);
            this.textBoxType.TabIndex = 2;
            this.textBoxType.Text = "youtube";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthor.Location = new System.Drawing.Point(117, 151);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(260, 35);
            this.textBoxAuthor.TabIndex = 3;
            this.textBoxAuthor.Text = "ゆうこ";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(117, 192);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(260, 35);
            this.textBoxComment.TabIndex = 4;
            this.textBoxComment.Text = "YouTubeのコメント";
            // 
            // textBoxTimestamp
            // 
            this.textBoxTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimestamp.Location = new System.Drawing.Point(117, 233);
            this.textBoxTimestamp.Name = "textBoxTimestamp";
            this.textBoxTimestamp.Size = new System.Drawing.Size(260, 35);
            this.textBoxTimestamp.TabIndex = 5;
            this.textBoxTimestamp.Text = "{\"year\":2025,\"month\":1,\"day\":2,\"hour\":3,\"minute\":4,\"second\":5,\"ms\":6}";
            // 
            // textBoxIconUrl
            // 
            this.textBoxIconUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIconUrl.Location = new System.Drawing.Point(117, 274);
            this.textBoxIconUrl.Name = "textBoxIconUrl";
            this.textBoxIconUrl.Size = new System.Drawing.Size(260, 35);
            this.textBoxIconUrl.TabIndex = 6;
            this.textBoxIconUrl.Text = "https://yt4.ggpht.com/a/default-user=s240-c-k-c0x00ffffff-no-rj";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(60, 113);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(61, 30);
            this.labelType.TabIndex = 999;
            this.labelType.Text = "type:";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.ForeColor = System.Drawing.Color.White;
            this.labelAuthor.Location = new System.Drawing.Point(39, 154);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(82, 30);
            this.labelAuthor.TabIndex = 999;
            this.labelAuthor.Text = "author:";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.ForeColor = System.Drawing.Color.White;
            this.labelComment.Location = new System.Drawing.Point(11, 195);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(110, 30);
            this.labelComment.TabIndex = 999;
            this.labelComment.Text = "comment:";
            this.labelComment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTimestamp
            // 
            this.labelTimestamp.AutoSize = true;
            this.labelTimestamp.ForeColor = System.Drawing.Color.White;
            this.labelTimestamp.Location = new System.Drawing.Point(0, 236);
            this.labelTimestamp.Name = "labelTimestamp";
            this.labelTimestamp.Size = new System.Drawing.Size(121, 30);
            this.labelTimestamp.TabIndex = 999;
            this.labelTimestamp.Text = "timestamp:";
            this.labelTimestamp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelIconUrl
            // 
            this.labelIconUrl.AutoSize = true;
            this.labelIconUrl.ForeColor = System.Drawing.Color.White;
            this.labelIconUrl.Location = new System.Drawing.Point(35, 277);
            this.labelIconUrl.Name = "labelIconUrl";
            this.labelIconUrl.Size = new System.Drawing.Size(86, 30);
            this.labelIconUrl.TabIndex = 999;
            this.labelIconUrl.Text = "iconUrl:";
            this.labelIconUrl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ComYtCmnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(384, 317);
            this.Controls.Add(this.textBoxIconUrl);
            this.Controls.Add(this.textBoxTimestamp);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.buttonYouTubeCommentOSC);
            this.Controls.Add(this.labelIconUrl);
            this.Controls.Add(this.labelTimestamp);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelOscAddress);
            this.Controls.Add(this.labelCommonAPI);
            this.Controls.Add(this.labelOSC);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ComYtCmnt";
            this.Text = "One Dummy (Common Yt Comment)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOSC;
        private System.Windows.Forms.Button buttonYouTubeCommentOSC;
        private System.Windows.Forms.Label labelCommonAPI;
        private System.Windows.Forms.Label labelOscAddress;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.TextBox textBoxTimestamp;
        private System.Windows.Forms.TextBox textBoxIconUrl;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelTimestamp;
        private System.Windows.Forms.Label labelIconUrl;
    }
}