namespace OneDummy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonYoutubeComment = new System.Windows.Forms.Button();
            this.buttonYouTubeSuperChat = new System.Windows.Forms.Button();
            this.buttonNiconamaComment = new System.Windows.Forms.Button();
            this.buttonNiconamaGift = new System.Windows.Forms.Button();
            this.panelCommonAPI = new System.Windows.Forms.Panel();
            this.buttonCommonNiconamaGift = new System.Windows.Forms.Button();
            this.buttonCommonNiconamaComment = new System.Windows.Forms.Button();
            this.buttonCommonYouTubeSuperChat = new System.Windows.Forms.Button();
            this.buttonCommonYouTubeComment = new System.Windows.Forms.Button();
            this.labelCommonOscAddress = new System.Windows.Forms.Label();
            this.labelCommonAPI = new System.Windows.Forms.Label();
            this.panelYoutTubeAPI = new System.Windows.Forms.Panel();
            this.labelYouTubeSuperChatOscAddress = new System.Windows.Forms.Label();
            this.labelYouTubeSuperChatAPI = new System.Windows.Forms.Label();
            this.labelYouTubeCommentOscAddress = new System.Windows.Forms.Label();
            this.labelYouTubeCommentAPI = new System.Windows.Forms.Label();
            this.labelNiconamaCommentAPI = new System.Windows.Forms.Label();
            this.labelNiconamaGiftAPI = new System.Windows.Forms.Label();
            this.labelNiconamaCommentOscAddress = new System.Windows.Forms.Label();
            this.labelNiconamaGiftOscAddress = new System.Windows.Forms.Label();
            this.panelNiconamaAPI = new System.Windows.Forms.Panel();
            this.linkLabelVirtualCastWiki = new System.Windows.Forms.LinkLabel();
            this.linkLabelVCIDocumentation = new System.Windows.Forms.LinkLabel();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.panelCommonAPI.SuspendLayout();
            this.panelYoutTubeAPI.SuspendLayout();
            this.panelNiconamaAPI.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonYoutubeComment
            // 
            this.buttonYoutubeComment.BackColor = System.Drawing.Color.White;
            this.buttonYoutubeComment.ForeColor = System.Drawing.Color.Maroon;
            this.buttonYoutubeComment.Location = new System.Drawing.Point(33, 52);
            this.buttonYoutubeComment.Name = "buttonYoutubeComment";
            this.buttonYoutubeComment.Size = new System.Drawing.Size(260, 41);
            this.buttonYoutubeComment.TabIndex = 8;
            this.buttonYoutubeComment.Text = "↪YouTubeコメント";
            this.buttonYoutubeComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYoutubeComment.UseVisualStyleBackColor = false;
            this.buttonYoutubeComment.Click += new System.EventHandler(this.buttonYoutubeComment_Click);
            // 
            // buttonYouTubeSuperChat
            // 
            this.buttonYouTubeSuperChat.BackColor = System.Drawing.Color.White;
            this.buttonYouTubeSuperChat.ForeColor = System.Drawing.Color.Maroon;
            this.buttonYouTubeSuperChat.Location = new System.Drawing.Point(33, 154);
            this.buttonYouTubeSuperChat.Name = "buttonYouTubeSuperChat";
            this.buttonYouTubeSuperChat.Size = new System.Drawing.Size(260, 41);
            this.buttonYouTubeSuperChat.TabIndex = 9;
            this.buttonYouTubeSuperChat.Text = "↪YouTubeスーパーチャット";
            this.buttonYouTubeSuperChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYouTubeSuperChat.UseVisualStyleBackColor = false;
            this.buttonYouTubeSuperChat.Click += new System.EventHandler(this.buttonYouTubeSuperChat_Click);
            // 
            // buttonNiconamaComment
            // 
            this.buttonNiconamaComment.BackColor = System.Drawing.Color.White;
            this.buttonNiconamaComment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonNiconamaComment.Location = new System.Drawing.Point(35, 52);
            this.buttonNiconamaComment.Name = "buttonNiconamaComment";
            this.buttonNiconamaComment.Size = new System.Drawing.Size(260, 41);
            this.buttonNiconamaComment.TabIndex = 10;
            this.buttonNiconamaComment.Text = "↪ニコ生コメント";
            this.buttonNiconamaComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNiconamaComment.UseVisualStyleBackColor = false;
            this.buttonNiconamaComment.Click += new System.EventHandler(this.buttonNiconamaComment_Click);
            // 
            // buttonNiconamaGift
            // 
            this.buttonNiconamaGift.BackColor = System.Drawing.Color.White;
            this.buttonNiconamaGift.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonNiconamaGift.Location = new System.Drawing.Point(35, 154);
            this.buttonNiconamaGift.Name = "buttonNiconamaGift";
            this.buttonNiconamaGift.Size = new System.Drawing.Size(260, 41);
            this.buttonNiconamaGift.TabIndex = 11;
            this.buttonNiconamaGift.Text = "↪ニコ生ギフト";
            this.buttonNiconamaGift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNiconamaGift.UseVisualStyleBackColor = false;
            this.buttonNiconamaGift.Click += new System.EventHandler(this.buttonNiconamaGift_Click);
            // 
            // panelCommonAPI
            // 
            this.panelCommonAPI.BackColor = System.Drawing.Color.Chocolate;
            this.panelCommonAPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCommonAPI.Controls.Add(this.buttonCommonNiconamaGift);
            this.panelCommonAPI.Controls.Add(this.buttonCommonNiconamaComment);
            this.panelCommonAPI.Controls.Add(this.buttonCommonYouTubeSuperChat);
            this.panelCommonAPI.Controls.Add(this.buttonCommonYouTubeComment);
            this.panelCommonAPI.Controls.Add(this.labelCommonOscAddress);
            this.panelCommonAPI.Controls.Add(this.labelCommonAPI);
            this.panelCommonAPI.Location = new System.Drawing.Point(12, 12);
            this.panelCommonAPI.Name = "panelCommonAPI";
            this.panelCommonAPI.Size = new System.Drawing.Size(670, 158);
            this.panelCommonAPI.TabIndex = 1;
            // 
            // buttonCommonNiconamaGift
            // 
            this.buttonCommonNiconamaGift.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonCommonNiconamaGift.Location = new System.Drawing.Point(374, 105);
            this.buttonCommonNiconamaGift.Name = "buttonCommonNiconamaGift";
            this.buttonCommonNiconamaGift.Size = new System.Drawing.Size(260, 41);
            this.buttonCommonNiconamaGift.TabIndex = 7;
            this.buttonCommonNiconamaGift.Text = "↪ニコ生ギフト";
            this.buttonCommonNiconamaGift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCommonNiconamaGift.UseVisualStyleBackColor = true;
            this.buttonCommonNiconamaGift.Click += new System.EventHandler(this.buttonCommonNiconamaGift_Click);
            // 
            // buttonCommonNiconamaComment
            // 
            this.buttonCommonNiconamaComment.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonCommonNiconamaComment.Location = new System.Drawing.Point(374, 58);
            this.buttonCommonNiconamaComment.Name = "buttonCommonNiconamaComment";
            this.buttonCommonNiconamaComment.Size = new System.Drawing.Size(260, 41);
            this.buttonCommonNiconamaComment.TabIndex = 6;
            this.buttonCommonNiconamaComment.Text = "↪ニコ生コメント";
            this.buttonCommonNiconamaComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCommonNiconamaComment.UseVisualStyleBackColor = true;
            this.buttonCommonNiconamaComment.Click += new System.EventHandler(this.buttonCommonNiconamaComment_Click);
            // 
            // buttonCommonYouTubeSuperChat
            // 
            this.buttonCommonYouTubeSuperChat.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonCommonYouTubeSuperChat.Location = new System.Drawing.Point(31, 105);
            this.buttonCommonYouTubeSuperChat.Name = "buttonCommonYouTubeSuperChat";
            this.buttonCommonYouTubeSuperChat.Size = new System.Drawing.Size(260, 41);
            this.buttonCommonYouTubeSuperChat.TabIndex = 5;
            this.buttonCommonYouTubeSuperChat.Text = "↪YouTubeスーパーチャット";
            this.buttonCommonYouTubeSuperChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCommonYouTubeSuperChat.UseVisualStyleBackColor = true;
            this.buttonCommonYouTubeSuperChat.Click += new System.EventHandler(this.buttonCommonYouTubeSuperChat_Click);
            // 
            // buttonCommonYouTubeComment
            // 
            this.buttonCommonYouTubeComment.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonCommonYouTubeComment.Location = new System.Drawing.Point(31, 58);
            this.buttonCommonYouTubeComment.Name = "buttonCommonYouTubeComment";
            this.buttonCommonYouTubeComment.Size = new System.Drawing.Size(260, 41);
            this.buttonCommonYouTubeComment.TabIndex = 4;
            this.buttonCommonYouTubeComment.Text = "↪YouTubeコメント";
            this.buttonCommonYouTubeComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCommonYouTubeComment.UseVisualStyleBackColor = true;
            this.buttonCommonYouTubeComment.Click += new System.EventHandler(this.buttonCommonYouTubeComment_Click);
            // 
            // labelCommonOscAddress
            // 
            this.labelCommonOscAddress.AutoSize = true;
            this.labelCommonOscAddress.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCommonOscAddress.Location = new System.Drawing.Point(3, 32);
            this.labelCommonOscAddress.Name = "labelCommonOscAddress";
            this.labelCommonOscAddress.Size = new System.Drawing.Size(250, 21);
            this.labelCommonOscAddress.TabIndex = 999;
            this.labelCommonOscAddress.Text = "/vc-official/onecomme/common";
            // 
            // labelCommonAPI
            // 
            this.labelCommonAPI.AutoSize = true;
            this.labelCommonAPI.Location = new System.Drawing.Point(2, 2);
            this.labelCommonAPI.Name = "labelCommonAPI";
            this.labelCommonAPI.Size = new System.Drawing.Size(150, 30);
            this.labelCommonAPI.TabIndex = 999;
            this.labelCommonAPI.Text = "●共通受信API";
            // 
            // panelYoutTubeAPI
            // 
            this.panelYoutTubeAPI.BackColor = System.Drawing.Color.Maroon;
            this.panelYoutTubeAPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYoutTubeAPI.Controls.Add(this.labelYouTubeSuperChatOscAddress);
            this.panelYoutTubeAPI.Controls.Add(this.labelYouTubeSuperChatAPI);
            this.panelYoutTubeAPI.Controls.Add(this.labelYouTubeCommentOscAddress);
            this.panelYoutTubeAPI.Controls.Add(this.labelYouTubeCommentAPI);
            this.panelYoutTubeAPI.Controls.Add(this.buttonYoutubeComment);
            this.panelYoutTubeAPI.Controls.Add(this.buttonYouTubeSuperChat);
            this.panelYoutTubeAPI.Location = new System.Drawing.Point(12, 179);
            this.panelYoutTubeAPI.Name = "panelYoutTubeAPI";
            this.panelYoutTubeAPI.Size = new System.Drawing.Size(330, 206);
            this.panelYoutTubeAPI.TabIndex = 2;
            // 
            // labelYouTubeSuperChatOscAddress
            // 
            this.labelYouTubeSuperChatOscAddress.AutoSize = true;
            this.labelYouTubeSuperChatOscAddress.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelYouTubeSuperChatOscAddress.Location = new System.Drawing.Point(6, 132);
            this.labelYouTubeSuperChatOscAddress.Name = "labelYouTubeSuperChatOscAddress";
            this.labelYouTubeSuperChatOscAddress.Size = new System.Drawing.Size(294, 21);
            this.labelYouTubeSuperChatOscAddress.TabIndex = 999;
            this.labelYouTubeSuperChatOscAddress.Text = "/vc-official/onecomme/youtube/super";
            // 
            // labelYouTubeSuperChatAPI
            // 
            this.labelYouTubeSuperChatAPI.AutoSize = true;
            this.labelYouTubeSuperChatAPI.Location = new System.Drawing.Point(2, 104);
            this.labelYouTubeSuperChatAPI.Name = "labelYouTubeSuperChatAPI";
            this.labelYouTubeSuperChatAPI.Size = new System.Drawing.Size(269, 30);
            this.labelYouTubeSuperChatAPI.TabIndex = 999;
            this.labelYouTubeSuperChatAPI.Text = "▶YouTubeスーパーチャットAPI";
            // 
            // labelYouTubeCommentOscAddress
            // 
            this.labelYouTubeCommentOscAddress.AutoSize = true;
            this.labelYouTubeCommentOscAddress.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelYouTubeCommentOscAddress.Location = new System.Drawing.Point(6, 28);
            this.labelYouTubeCommentOscAddress.Name = "labelYouTubeCommentOscAddress";
            this.labelYouTubeCommentOscAddress.Size = new System.Drawing.Size(323, 21);
            this.labelYouTubeCommentOscAddress.TabIndex = 999;
            this.labelYouTubeCommentOscAddress.Text = "/vc-official/onecomme/youtube/comment";
            // 
            // labelYouTubeCommentAPI
            // 
            this.labelYouTubeCommentAPI.AutoSize = true;
            this.labelYouTubeCommentAPI.Location = new System.Drawing.Point(2, 2);
            this.labelYouTubeCommentAPI.Name = "labelYouTubeCommentAPI";
            this.labelYouTubeCommentAPI.Size = new System.Drawing.Size(208, 30);
            this.labelYouTubeCommentAPI.TabIndex = 999;
            this.labelYouTubeCommentAPI.Text = "▶YouTubeコメントAPI";
            // 
            // labelNiconamaCommentAPI
            // 
            this.labelNiconamaCommentAPI.AutoSize = true;
            this.labelNiconamaCommentAPI.Location = new System.Drawing.Point(2, 2);
            this.labelNiconamaCommentAPI.Name = "labelNiconamaCommentAPI";
            this.labelNiconamaCommentAPI.Size = new System.Drawing.Size(179, 30);
            this.labelNiconamaCommentAPI.TabIndex = 999;
            this.labelNiconamaCommentAPI.Text = "■ニコ生コメントAPI";
            // 
            // labelNiconamaGiftAPI
            // 
            this.labelNiconamaGiftAPI.AutoSize = true;
            this.labelNiconamaGiftAPI.Location = new System.Drawing.Point(2, 104);
            this.labelNiconamaGiftAPI.Name = "labelNiconamaGiftAPI";
            this.labelNiconamaGiftAPI.Size = new System.Drawing.Size(164, 30);
            this.labelNiconamaGiftAPI.TabIndex = 999;
            this.labelNiconamaGiftAPI.Text = "■ニコ生ギフトAPI";
            // 
            // labelNiconamaCommentOscAddress
            // 
            this.labelNiconamaCommentOscAddress.AutoSize = true;
            this.labelNiconamaCommentOscAddress.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNiconamaCommentOscAddress.Location = new System.Drawing.Point(6, 28);
            this.labelNiconamaCommentOscAddress.Name = "labelNiconamaCommentOscAddress";
            this.labelNiconamaCommentOscAddress.Size = new System.Drawing.Size(324, 21);
            this.labelNiconamaCommentOscAddress.TabIndex = 999;
            this.labelNiconamaCommentOscAddress.Text = "/vc-official/onecomme/niconico/comment";
            // 
            // labelNiconamaGiftOscAddress
            // 
            this.labelNiconamaGiftOscAddress.AutoSize = true;
            this.labelNiconamaGiftOscAddress.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNiconamaGiftOscAddress.Location = new System.Drawing.Point(6, 132);
            this.labelNiconamaGiftOscAddress.Name = "labelNiconamaGiftOscAddress";
            this.labelNiconamaGiftOscAddress.Size = new System.Drawing.Size(280, 21);
            this.labelNiconamaGiftOscAddress.TabIndex = 999;
            this.labelNiconamaGiftOscAddress.Text = "/vc-official/onecomme/niconico/gift";
            // 
            // panelNiconamaAPI
            // 
            this.panelNiconamaAPI.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelNiconamaAPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNiconamaAPI.Controls.Add(this.labelNiconamaGiftOscAddress);
            this.panelNiconamaAPI.Controls.Add(this.labelNiconamaCommentAPI);
            this.panelNiconamaAPI.Controls.Add(this.labelNiconamaGiftAPI);
            this.panelNiconamaAPI.Controls.Add(this.labelNiconamaCommentOscAddress);
            this.panelNiconamaAPI.Controls.Add(this.buttonNiconamaComment);
            this.panelNiconamaAPI.Controls.Add(this.buttonNiconamaGift);
            this.panelNiconamaAPI.Location = new System.Drawing.Point(352, 179);
            this.panelNiconamaAPI.Name = "panelNiconamaAPI";
            this.panelNiconamaAPI.Size = new System.Drawing.Size(330, 206);
            this.panelNiconamaAPI.TabIndex = 3;
            // 
            // linkLabelVirtualCastWiki
            // 
            this.linkLabelVirtualCastWiki.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelVirtualCastWiki.AutoSize = true;
            this.linkLabelVirtualCastWiki.LinkColor = System.Drawing.Color.White;
            this.linkLabelVirtualCastWiki.Location = new System.Drawing.Point(15, 406);
            this.linkLabelVirtualCastWiki.Name = "linkLabelVirtualCastWiki";
            this.linkLabelVirtualCastWiki.Size = new System.Drawing.Size(193, 30);
            this.linkLabelVirtualCastWiki.TabIndex = 6;
            this.linkLabelVirtualCastWiki.TabStop = true;
            this.linkLabelVirtualCastWiki.Text = "🔗VirtualCast Wiki";
            this.linkLabelVirtualCastWiki.VisitedLinkColor = System.Drawing.Color.Indigo;
            this.linkLabelVirtualCastWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVirtualCastWiki_LinkClicked);
            // 
            // linkLabelVCIDocumentation
            // 
            this.linkLabelVCIDocumentation.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelVCIDocumentation.AutoSize = true;
            this.linkLabelVCIDocumentation.LinkColor = System.Drawing.Color.White;
            this.linkLabelVCIDocumentation.Location = new System.Drawing.Point(256, 406);
            this.linkLabelVCIDocumentation.Name = "linkLabelVCIDocumentation";
            this.linkLabelVCIDocumentation.Size = new System.Drawing.Size(230, 30);
            this.linkLabelVCIDocumentation.TabIndex = 7;
            this.linkLabelVCIDocumentation.TabStop = true;
            this.linkLabelVCIDocumentation.Text = "🔗VCI Documentation";
            this.linkLabelVCIDocumentation.VisitedLinkColor = System.Drawing.Color.Indigo;
            this.linkLabelVCIDocumentation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVCIDocumentation_LinkClicked);
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.LinkColor = System.Drawing.Color.White;
            this.linkLabelGitHub.Location = new System.Drawing.Point(560, 406);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(111, 30);
            this.linkLabelGitHub.TabIndex = 8;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "🔗GitHub";
            this.linkLabelGitHub.VisitedLinkColor = System.Drawing.Color.Indigo;
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(696, 445);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.linkLabelVCIDocumentation);
            this.Controls.Add(this.linkLabelVirtualCastWiki);
            this.Controls.Add(this.panelNiconamaAPI);
            this.Controls.Add(this.panelYoutTubeAPI);
            this.Controls.Add(this.panelCommonAPI);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "MainForm";
            this.Text = "わんダミー (OSC) One Dummy v1.0 [VirtualCast公式わんコメOSCプラグイン Ver 1.2.0 対応版]";
            this.panelCommonAPI.ResumeLayout(false);
            this.panelCommonAPI.PerformLayout();
            this.panelYoutTubeAPI.ResumeLayout(false);
            this.panelYoutTubeAPI.PerformLayout();
            this.panelNiconamaAPI.ResumeLayout(false);
            this.panelNiconamaAPI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonYoutubeComment;
        private System.Windows.Forms.Button buttonYouTubeSuperChat;
        private System.Windows.Forms.Button buttonNiconamaComment;
        private System.Windows.Forms.Button buttonNiconamaGift;
        private System.Windows.Forms.Panel panelCommonAPI;
        private System.Windows.Forms.Label labelCommonAPI;
        private System.Windows.Forms.Panel panelYoutTubeAPI;
        private System.Windows.Forms.Button buttonCommonYouTubeComment;
        private System.Windows.Forms.Label labelCommonOscAddress;
        private System.Windows.Forms.Button buttonCommonYouTubeSuperChat;
        private System.Windows.Forms.Button buttonCommonNiconamaGift;
        private System.Windows.Forms.Button buttonCommonNiconamaComment;
        private System.Windows.Forms.Label labelYouTubeCommentOscAddress;
        private System.Windows.Forms.Label labelYouTubeCommentAPI;
        private System.Windows.Forms.Label labelNiconamaGiftOscAddress;
        private System.Windows.Forms.Label labelNiconamaCommentOscAddress;
        private System.Windows.Forms.Label labelNiconamaGiftAPI;
        private System.Windows.Forms.Label labelNiconamaCommentAPI;
        private System.Windows.Forms.Label labelYouTubeSuperChatOscAddress;
        private System.Windows.Forms.Label labelYouTubeSuperChatAPI;
        private System.Windows.Forms.Panel panelNiconamaAPI;
        private System.Windows.Forms.LinkLabel linkLabelVirtualCastWiki;
        private System.Windows.Forms.LinkLabel linkLabelVCIDocumentation;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
    }
}