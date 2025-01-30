// 20250130 v1.0 Taki

using System;
using System.Windows.Forms;

namespace OneDummy
{
    public partial class MainForm : Form
    {
        // Form用
        private ComYtCmnt _formCommonYouTubeComment;
        private ComYtSuper _formCommonYouTubeSuperChat;
        private ComNiCmnt _formCommonNiconamaComment;
        private ComNiGift _formCommonNiconamaGift;

        private YtComment _formYouTubeComment;
        private YtSuperChat _formYouTubeSuperChat;
        private NiComment _formNiconamaComment;
        private NiGift _formNiconamaGift;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCommonYouTubeComment_Click(object sender, EventArgs e)
        {
            if (_formCommonYouTubeComment == null || _formCommonYouTubeComment.IsDisposed)
            {
                //フォームの生成
                _formCommonYouTubeComment = new ComYtCmnt();
                _formCommonYouTubeComment.Show();
            }
            else
            {
                _formCommonYouTubeComment.Focus();
            }
        }

        private void buttonCommonYouTubeSuperChat_Click(object sender, EventArgs e)
        {
            if (_formCommonYouTubeSuperChat == null || _formCommonYouTubeSuperChat.IsDisposed)
            {
                //フォームの生成
                _formCommonYouTubeSuperChat = new ComYtSuper();
                _formCommonYouTubeSuperChat.Show();
            }
            else
            {
                _formCommonYouTubeSuperChat.Focus();
            }
        }

        private void buttonCommonNiconamaComment_Click(object sender, EventArgs e)
        {
            if (_formCommonNiconamaComment == null || _formCommonNiconamaComment.IsDisposed)
            {
                //フォームの生成
                _formCommonNiconamaComment = new ComNiCmnt();
                _formCommonNiconamaComment.Show();
            }
            else
            {
                _formCommonNiconamaComment.Focus();
            }
        }

        private void buttonCommonNiconamaGift_Click(object sender, EventArgs e)
        {
            if (_formCommonNiconamaGift == null || _formCommonNiconamaGift.IsDisposed)
            {
                //フォームの生成
                _formCommonNiconamaGift = new ComNiGift();
                _formCommonNiconamaGift.Show();
            }
            else
            {
                _formCommonNiconamaGift.Focus();
            }
        }

        private void buttonYoutubeComment_Click(object sender, EventArgs e)
        {
            if (_formYouTubeComment == null || _formYouTubeComment.IsDisposed)
            {
                //フォームの生成
                _formYouTubeComment = new YtComment();
                _formYouTubeComment.Show();
            }
            else
            {
                _formYouTubeComment.Focus();
            }
        }

        private void buttonYouTubeSuperChat_Click(object sender, EventArgs e)
        {
            if (_formYouTubeSuperChat == null || _formYouTubeSuperChat.IsDisposed)
            {
                //フォームの生成
                _formYouTubeSuperChat = new YtSuperChat();
                _formYouTubeSuperChat.Show();
            }
            else
            {
                _formYouTubeSuperChat.Focus();
            }
        }

        private void buttonNiconamaComment_Click(object sender, EventArgs e)
        {
            if (_formNiconamaComment == null || _formNiconamaComment.IsDisposed)
            {
                //フォームの生成
                _formNiconamaComment = new NiComment();
                _formNiconamaComment.Show();
            }
            else
            {
                _formNiconamaComment.Focus();
            }
        }

        private void buttonNiconamaGift_Click(object sender, EventArgs e)
        {
            if (_formNiconamaGift == null || _formNiconamaGift.IsDisposed)
            {
                //フォームの生成
                _formNiconamaGift = new NiGift();
                _formNiconamaGift.Show();
            }
            else
            {
                _formNiconamaGift.Focus();
            }
        }

        // https://learn.microsoft.com/ja-jp/dotnet/desktop/winforms/controls/link-to-an-object-or-web-page-with-wf-linklabel-control?view=netframeworkdesktop-4.8
        private void linkLabelVirtualCastWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Change the color of the link text by setting LinkVisited
                // to true.
                linkLabelVirtualCastWiki.LinkVisited = true;
                //Call the Process.Start method to open the default browser
                //with a URL:
                System.Diagnostics.Process.Start("https://wiki.virtualcast.jp/wiki/deliverytool/onecomme/plugin");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link [ https://wiki.virtualcast.jp/wiki/deliverytool/onecomme/plugin ].");
            }
        }

        private void linkLabelVCIDocumentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Change the color of the link text by setting LinkVisited
                // to true.
                linkLabelVCIDocumentation.LinkVisited = true;
                //Call the Process.Start method to open the default browser
                //with a URL:
                System.Diagnostics.Process.Start("https://developer.virtualcast.jp/vci-docs/manual/osc/onecomme_osc/index.html");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link [ https://developer.virtualcast.jp/vci-docs/manual/osc/onecomme_osc/index.html ].");
            }
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Change the color of the link text by setting LinkVisited
                // to true.
                linkLabelGitHub.LinkVisited = true;
                //Call the Process.Start method to open the default browser
                //with a URL:
                System.Diagnostics.Process.Start("https://github.com/co1956457/OneDummyOSC");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link [ https://github.com/co1956457/OneDummyOSC ].");
            }
        }
    }


    // 以下、JsonSerializer の名残。実際の文字列が参考になるので残しておく。
    // NiGift.cs 参照
    //
    //    // https://developer.virtualcast.jp/vci-docs/manual/osc/onecomme_osc/index.html
    //    // ↑webの情報と実際の情報が異なっていることがあるので要注意!
    //    // 実際にモニタリングして得られた情報に合わる
    //    // 桁数は参考値
    //    /*
    //    /vc-official/onecomme/common
    //    {"type":"youtube","author":"ゆうこ","comment":"YouTubeコメント","timestamp":{"year":2025,"month":1,"day":2,"hour":3,"minute":4,"second":5,"ms":6},"iconUrl":"https://yt4.ggpht.com/ketafumeiEisuu=s240-c-k-c0x00ffffff-no-rj"}
    //    {"type":"niconico","author":"にこ","comment":"ニコ生こめんと","timestamp":{"year":2025,"month":11,"day":12,"hour":13,"minute":14,"second":15,"ms":16},"iconUrl":"https://secure-dcdn.cdn.nimg.jp/nicoaccount/usericon/99999/999994444.jpg"}
    //
    //    /vc-official/onecomme/common
    //    {"type":"youtube-super","author":"太郎","comment":"","timestamp":{"year":2025,"month":12,"day":31,"hour":23,"minute":59,"second":59,"ms":999},"iconUrl":"https://yt4.ggpht.com/ExampleKetaFumeiEisuu=s240-c-k-c0x00ffffff-no-rj","paidText":"JP¥800","price":800,"tier":3,"unit":"JP¥","colors":{"headerBackgroundColor":{"r":0,"g":191,"b":165,"a":1},"headerTextColor":{"r":0,"g":0,"b":0,"a":1},"bodyBackgroundColor":{"r":29,"g":233,"b":182,"a":1},"bodyTextColor":{"r":0,"g":0,"b":0,"a":1},"authorNameTextColor":{"r":0,"g":0,"b":0,"a":0.5411764705882353},"timestampColor":{"r":0,"g":0,"b":0,"a":0.5019607843137255}}}
    //    {"type":"youtube-super","author":"次郎","comment":"コメント","timestamp":{"year":2025,"month":1,"day":1,"hour":0,"minute":0,"second":0,"ms":0},"iconUrl":"https://yt4.ggpht.com/ExampleKetaFumeiEisuu=s240-c-k-c0x00ffffff-no-rj","paidText":"JP¥800","price":800,"tier":3,"unit":"JP¥","colors":{"headerBackgroundColor":{"r":0,"g":191,"b":165,"a":1},"headerTextColor":{"r":0,"g":0,"b":0,"a":1},"bodyBackgroundColor":{"r":29,"g":233,"b":182,"a":1},"bodyTextColor":{"r":0,"g":0,"b":0,"a":1},"authorNameTextColor":{"r":0,"g":0,"b":0,"a":0.5411764705882353},"timestampColor":{"r":0,"g":0,"b":0,"a":0.5019607843137255}}}
    //
    //    /vc-official/onecomme/common
    //    {"type":"niconico-gift","author":"名無し","comment":" 【ギフト貢献第1位】 名無しさんが「投げろ！雪玉（0pt）」を贈りました","timestamp":{"year":2025,"month":1,"day":2,"hour":3,"minute":4,"second":5,"ms":6},"iconUrl":"https://secure-dcdn.cdn.nimg.jp/nicoaccount/usericon//.jpg","price":0}
    //
    //    /vc-official/onecomme/youtube/comment
    //    {"id":"yt-Example40ketaEisuu","liveId":"11ketaEisuu","userId":"yt-24ketaEisuu-QvzXWlg","name":"ゆうこ","isOwner":false,"isModerator":false,"isMember":false,"autoModerated":false,"timestamp":{"year":2025,"month":1,"day":2,"hour":3,"minute":4,"second":5,"ms":6},"hasGift":false,"comment":"コメント","displayName":"ゆうこ","profileImageUrl":"https://yt4.ggpht.com/ExampleKetaFumeiEisuu=s240-c-k-c0x00ffffff-no-rj","type":"youtube","endpoint":"/vc-official/onecomme/youtube/comment"}
    //
    //    /vc-official/onecomme/youtube/super
    //    {"id":"yt-Example40ketaEisuu","liveId":"11ketaEisuu","userId":"yt-24ketaEisuu","name":"太郎","isOwner":false,"isModerator":false,"isMember":false,"autoModerated":false,"timestamp":{"year":2025,"month":1,"day":2,"hour":3,"minute":4,"second":5,"ms":6},"hasGift":true,"comment":"","displayName":"太郎","profileImageUrl":"https://yt4.ggpht.com/ExampleKetaFumeiEisuu=s240-c-k-c0x00ffffff-no-rj","type":"youtube-super","endpoint":"/vc-official/onecomme/youtube/super","paidText":"JP¥800","price":800,"unit":"JP¥","colors":{"headerBackgroundColor":{"r":0,"g":191,"b":165,"a":1},"headerTextColor":{"r":0,"g":0,"b":0,"a":1},"bodyBackgroundColor":{"r":29,"g":233,"b":182,"a":1},"bodyTextColor":{"r":0,"g":0,"b":0,"a":1},"authorNameTextColor":{"r":0,"g":0,"b":0,"a":0.5411764705882353},"timestampColor":{"r":0,"g":0,"b":0,"a":0.5019607843137255}},"tier":3}
    //
    //    メンバーシップ初コメはSuperChat扱い?
    //    tierの項目が無い?
    //    {"id":"yt-Example40ketaEisuu","liveId":"11ketaEisuu","userId":"yt-24ketaEisuu","name":"花子","isOwner":false,"isModerator":false,"isMember":true,"autoModerated":false,"timestamp":{"year":2025,"month":1,"day":2,"hour":3,"minute":4,"second":5,"ms":6},"hasGift":true,"comment":"<div class=\"yt-header-sub-text\">コメント</div>","displayName":"花子","profileImageUrl":"https://yt4.ggpht.com/ytc/ExampleKetaFumeiEisuu=s240-c-k-c0x00ffffff-no-rj","type":"youtube-super","endpoint":"/vc-official/onecomme/youtube/super","paidText":"","price":0,"unit":"","colors":{"headerBackgroundColor":{"r":11,"g":128,"b":67,"a":1},"headerTextColor":{"r":255,"g":255,"b":255,"a":1},"bodyBackgroundColor":{"r":15,"g":157,"b":88,"a":1},"bodyTextColor":{"r":255,"g":255,"b":255,"a":1},"authorNameTextColor":{"r":255,"g":255,"b":255,"a":1},"timestampColor":{"r":255,"g":255,"b":255,"a":1}}}
    //
    //    /vc-official/onecomme/niconico/comment
    //    {"id":"ni-EhkKEg30ketaEisuu","liveId":"lv123456789-1234567890","userId":"ni-IDnumber","name":"にこ","screenName":"IDnumber","timestamp":{"year":2025,"month":1,"day":2,"hour":3,"minute":4,"second":5,"ms":6},"isOwner":false,"hasGift":false,"no":295,"comment":"コメント","premium":true,"anonymity":false,"displayName":"にこ","profileImageUrl":"https://secure-dcdn.cdn.nimg.jp/nicoaccount/usericon/number/IDnumber.jpg","type":"niconico","endpoint":"/vc-official/onecomme/niconico/comment"}
    //    */
    //
    //    public class NiconamaGiftObj
    //    {
    //        /*
    //        /vc-official/onecomme/niconico/gift
    //        {"id":"ni-EhkKEg30ketaEisuu","liveId":"lv123456789-1234567890","userId":"ni-IDnumber","name":"ニコギフ","screenName":"IDnumber","timestamp":{"year":2025,"month":1,"day":2,"hour":3,"minute":4,"second":5,"ms":6},"isOwner":false,"hasGift":true,"comment":" 【ギフト貢献第1位】 ニコギフさんが「喫茶ニコニコ コーヒーフロート（800pt）」を贈りました","anonymity":false,"displayName":"Tetsuo","profileImageUrl":"https://secure-dcdn.cdn.nimg.jp/nicoaccount/usericon/partOfIDnumber/IDnumber.jpg","type":"niconico-gift","endpoint":"/vc-official/onecomme/niconico/gift","price":800}
    //        {"id":"ni-EhkKEg30ketaEisuu","liveId":"lv123456789-1234567890","userId":"ni-","name":"名無し","screenName":"","timestamp":{"year":2025,"month":1,"day":2,"hour":3,"minute":4,"second":5,"ms":6},"isOwner":false,"hasGift":true,"comment":" 【ギフト貢献第2位】 名無しさんが「応援メガホン 青紫（5pt）」を贈りました","anonymity":true,"displayName":"名無し","profileImageUrl":"https://secure-dcdn.cdn.nimg.jp/nicoaccount/usericon//.jpg","type":"niconico-gift","endpoint":"/vc-official/onecomme/niconico/gift","price":5}
    //        {"id":"ni-EhkKEg30ketaEisuu","liveId":"lv123456789-1234567890","userId":"ni-","name":"名無し","screenName":"","timestamp":{"year":2025,"month":1,"day":2,"hour":3,"minute":4,"second":5,"ms":6},"isOwner":false,"hasGift":true,"comment":" 【ギフト貢献第3位】 名無しさんが「投げろ！雪玉（0pt）」を贈りました","anonymity":true,"displayName":"名無し","profileImageUrl":"https://secure-dcdn.cdn.nimg.jp/nicoaccount/usericon//.jpg","type":"niconico-gift","endpoint":"/vc-official/onecomme/niconico/gift","price":0}
    //         */
    //        public string id { get; set; }
    //        public string liveId { get; set; }
    //        public string userId { get; set; }
    //        public string name { get; set; }
    //        public string screenName { get; set; }
    //
    //        //public DateTimeInfo timestamp { get; set; } // JsonSerializer.Deserialize<DateTimeInfo>用
    //        public string timestamp { get; set; }
    //
    //        public bool isOwner { get; set; }
    //        public bool hasGift { get; set; }
    //        public string comment { get; set; }
    //        public bool anonymity { get; set; }
    //        public string displayName { get; set; }
    //        public string profileImageUrl { get; set; }
    //        public string type { get; set; } // "niconico-gift"
    //        public string endpoint { get; set; } // "/vc-official/onecomme/niconico/gift"
    //        public int price { get; set; }
    //
    //        // public int no { get; set; }
    //        // public bool premium { get; set; }
    //    }
    //
    //
    //    // JsonSerializer.Deserialize<DateTimeInfo>用
    //    public class DateTimeInfo
    //    {
    //      public int month { get; set; }
    //      public int day { get; set; }
    //      public int hour { get; set; }
    //      public int minute { get; set; }
    //      public int second { get; set; }
    //      public int ms { get; set; }
    //    }


}
