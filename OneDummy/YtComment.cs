using System;
using System.Text;
using System.Windows.Forms;


using System.IO; // for debugging

namespace OneDummy
{
    public partial class YtComment : Form
    {
        public YtComment()
        {
            InitializeComponent();
        }

        private void buttonYtCommentOSC_Click(object sender, EventArgs e)
        {
            // シリアライズ: フォーム情報から json 形式に整形したテキストを取得
            string jsonString = YouTubeCommentSerialize();

            // デバッグ for debugging purposes
            // string path = @"C:\example\";
            // File.WriteAllText(path + "youTubeComment.txt", jsonString);

            // OSC で JSON ファイルを送信
            string oscAddress = labelOscAddress.Text;
            SendOsc(oscAddress, jsonString);
        }

        private string YouTubeCommentSerialize()
        {
            string isOwnerText = "false";
            foreach (Control control in groupBoxIsOwner.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // 選択されている RadioButton のテキストを取得
                    isOwnerText = radioButton.Text;
                    break; // 1つの選択された RadioButton が見つかればループを終了
                }
            }

            string isModeratorText = "false";
            foreach (Control control in groupBoxIsModerator.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // 選択されている RadioButton のテキストを取得
                    isModeratorText = radioButton.Text;
                    break; // 1つの選択された RadioButton が見つかればループを終了
                }
            }

            string isMemberText = "false";
            foreach (Control control in groupBoxIsMember.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // 選択されている RadioButton のテキストを取得
                    isMemberText = radioButton.Text;
                    break; // 1つの選択された RadioButton が見つかればループを終了
                }
            }

            string autoModeratedText = "false";
            foreach (Control control in groupBoxAutoModerated.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // 選択されている RadioButton のテキストを取得
                    autoModeratedText = radioButton.Text;
                    break; // 1つの選択された RadioButton が見つかればループを終了
                }
            }

            string hasGiftText = "false";
            foreach (Control control in groupBoxHasGift.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // 選択されている RadioButton のテキストを取得
                    hasGiftText = radioButton.Text;
                    break; // 1つの選択された RadioButton が見つかればループを終了
                }
            }

            // テキスト情報を読み取り JSON 化
            // 外部参照 dll 同梱云々の関係から、結局、手動で jsonString を作成することとした。
            // JsonSerializer の使い方は NiGift.cs に残しておいた。
            string jsonString = "{" +
                                "\"id\":\"" + textBoxID.Text + "\"," +
                                "\"liveId\":\"" + textBoxLiveID.Text + "\"," +
                                "\"userId\":\"" + textBoxUserID.Text + "\"," +
                                "\"name\":\"" + textBoxName.Text + "\"," +
                                "\"isOwner\":" + isOwnerText + "," +
                                "\"isModerator\":" + isModeratorText + "," +
                                "\"isMember\":" + isMemberText + "," +
                                "\"autoModerated\":" + autoModeratedText + "," +
                                "\"timestamp\":" + textBoxTimestamp.Text + "," +
                                "\"hasGift\":" + hasGiftText + "," +
                                "\"comment\":\"" + textBoxComment.Text + "\"," +
                                "\"displayName\":\"" + textBoxDisplayName.Text + "\"," +
                                "\"profileImageUrl\":\"" + textBoxProfileImageUrl.Text + "\"," +
                                "\"type\":\"" + textBoxType.Text + "\"," +
                                "\"endpoint\":\"" + textBoxEndpoint.Text + "\"" +
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
