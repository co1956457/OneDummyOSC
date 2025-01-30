using System;
using System.Text;
using System.Windows.Forms;


using System.IO; // for debugging

namespace OneDummy
{
    public partial class ComYtCmnt : Form
    {
        public ComYtCmnt()
        {
            InitializeComponent();
        }

        private void buttonYouTubeCommentOSC_Click(object sender, EventArgs e)
        {
            // シリアライズ: フォーム情報から json 形式に整形したテキストを取得
            string jsonString = CommonYouTubeCommentSerialize();

            // デバッグ for debugging purposes
            // string path = @"C:\example\";
            // File.WriteAllText(path + "commonYouTubeComment.txt", jsonString);

            // OSC で JSON ファイルを送信
            string oscAddress = labelOscAddress.Text;
            SendOsc(oscAddress, jsonString);
        }
        private string CommonYouTubeCommentSerialize()
        {
            // テキスト情報を読み取り JSON 化
            // 外部参照 dll 同梱云々の関係から、結局、手動で jsonString を作成することとした。
            // JsonSerializer の使い方は NiGift.cs に残しておいた。
            string jsonString = "{" +
                                "\"type\":\"" + textBoxType.Text + "\"," +
                                "\"author\":\"" + textBoxAuthor.Text + "\"," +
                                "\"comment\":\"" + textBoxComment.Text + "\"," +
                                "\"timestamp\":" + textBoxTimestamp.Text + "," +
                                "\"iconUrl\":\"" + textBoxIconUrl.Text + "\"" +
                                "}";
            return jsonString;
        }


        // OSC で送信
        // SharpOSC (MIT license) を部分利用
        // https://github.com/ValdemarOrn/SharpOSC
        //
        static void SendOsc(string oscAddress, string jsonString)
        {
            try
            {
                Encoding utf8 = Encoding.UTF8;
                byte[] blob_jsonString = utf8.GetBytes(jsonString);

                var sender = new UDPSender("127.0.0.1", 19100);
                var message = new OscMessage(oscAddress, blob_jsonString);

                sender.Send(message);
            }
            // for debugging purposes
            //catch (Exception error)
            catch (Exception)
            {
                // for debugging purposes
                // MessageBox.Show(error.ToString());
            }
        }
    }
}
