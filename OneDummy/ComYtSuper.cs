using System;
using System.Text;
using System.Windows.Forms;


using System.IO; // for debugging

namespace OneDummy
{
    public partial class ComYtSuper : Form
    {
        public ComYtSuper()
        {
            InitializeComponent();
        }

        private void buttonYouTubeSuperChatOSC_Click(object sender, System.EventArgs e)
        {
            // シリアライズ: フォーム情報から json 形式に整形したテキストを取得
            string jsonString = CommonYouTubeSuperChatSerialize();

            // デバッグ for debugging purposes
            // string path = @"C:\example\";
            // File.WriteAllText(path + "commonYouTubeSuperChat.txt", jsonString);

            // OSC で JSON ファイルを送信
            string oscAddress = labelOscAddress.Text;
            SendOsc(oscAddress, jsonString);
        }

        private string CommonYouTubeSuperChatSerialize()
        {
            // テキスト情報を読み取り JSON 化
            // 外部参照 dll 同梱云々の関係から、結局、手動で jsonString を作成することとした。
            // JsonSerializer の使い方は NiGift.cs に残しておいた。
            string jsonString = "{" +
                                "\"type\":\"" + textBoxType.Text + "\"," +
                                "\"author\":\"" + textBoxAuthor.Text + "\"," +
                                "\"comment\":\"" + textBoxComment.Text + "\"," +
                                "\"timestamp\":" + textBoxTimestamp.Text + "," +
                                "\"iconUrl\":\"" + textBoxIconUrl.Text + "\"," +
                                "\"paidText\":\"" + textBoxPaidText.Text + "\"," +
                                "\"price\":" + textBoxPrice.Text + "," +
                                "\"tier\":" + textBoxTier.Text + "," +
                                "\"unit\":\"" + textBoxUnit.Text + "\"," +
                                "\"colors\":" + textBoxColors.Text +
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

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 数字とコントロールキー以外の入力を無効にする
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTier_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 数字とコントロールキー以外の入力を無効にする
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
