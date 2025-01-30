using System;
using System.Text;
using System.Windows.Forms;


using System.IO; // for debugging
/*
using System.Text.Json;
using System.Text.Encodings.Web;
 */
namespace OneDummy
{
    public partial class NiGift : Form
    {
        public NiGift()
        {
            InitializeComponent();
        }

        private void buttonNiconamaGiftOSC_Click(object sender, EventArgs e)
        {
            // シリアライズ: フォーム情報から json 形式に整形したテキストを取得
            string jsonString = NiconamaGiftSerialize();

            // デバッグ for debugging purposes
            // string path = @"C:\example\";
            // File.WriteAllText(path + "niconamaGift.txt", jsonString);

            // OSC で JSON ファイルを送信
            string oscAddress = labelOscAddress.Text;
            SendOsc(oscAddress, jsonString);
        }

        private string NiconamaGiftSerialize()
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

            string hasGiftText = "true";
            foreach (Control control in groupBoxHasGift.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // 選択されている RadioButton のテキストを取得
                    hasGiftText = radioButton.Text;
                    break; // 1つの選択された RadioButton が見つかればループを終了
                }
            }

            string anonymityText = "true";
            foreach (Control control in groupBoxAnonymity.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // 選択されている RadioButton のテキストを取得
                    anonymityText = radioButton.Text;
                    break; // 1つの選択された RadioButton が見つかればループを終了
                }
            }


            // テキスト情報を読み取り JSON 化
            // 外部参照 dll 同梱云々の関係から、結局、手動で jsonString を作成することとした。
            // 後の振り返り用に、JsonSerializer の使い方を残しておく。
            // 参照追加は System.Memory, System.Text.Json, System.Text.Encodings.Web の３つ
            /*
            var dateTimeInfo = JsonSerializer.Deserialize<DateTimeInfo>(textBoxTimestamp.Text);

            var niconamaGiftObj = new NiconamaGiftObj
            {
                id = textBoxID.Text,
                liveId = textBoxLiveID.Text,
                userId = textBoxUserID.Text,
                name = textBoxName.Text,
                screenName = textBoxScreenName.Text,
                timestamp = dateTimeInfo,
                isOwner = Convert.ToBoolean(isOwnerText),
                hasGift = Convert.ToBoolean(hasGiftText),
                comment = textBoxComment.Text,
                anonymity = Convert.ToBoolean(anonymityText),
                displayName = textBoxDisplayName.Text,
                profileImageUrl = textBoxProfileImageUrl.Text,
                type = textBoxType.Text,
                endpoint = textBoxEndpoint.Text,
                price = Convert.ToInt32(textBoxPrice.Text)
            };

            // JsonSerializer.Serialize は自動的に日本語やエスケープシーケンスを unicode 化
            // 例: name = "太郎" →　{"name":"\u592A\u90CE"}
            // optionを設定することで解決
            // https://learn.microsoft.com/ja-jp/dotnet/standard/serialization/system-text-json/character-encoding
            var options3 = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping //,
                // WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(niconamaGiftObj, options3);
             */

            string jsonString = "{" + 
                                "\"id\":\"" + textBoxID.Text + "\"," +
                                "\"liveId\":\"" + textBoxLiveID.Text + "\"," +
                                "\"userId\":\"" + textBoxUserID.Text + "\"," +
                                "\"name\":\"" + textBoxName.Text + "\"," +
                                "\"screenName\":\"" + textBoxScreenName.Text + "\"," +
                                "\"timestamp\":" + textBoxTimestamp.Text + "," +
                                "\"isOwner\":" + isOwnerText + "," +
                                "\"hasGift\":" + hasGiftText + "," +
                                "\"comment\":\"" + textBoxComment.Text + "\"," +
                                "\"anonymity\":" + anonymityText + "," +
                                "\"displayName\":\"" + textBoxDisplayName.Text + "\"," +
                                "\"profileImageUrl\":\"" + textBoxProfileImageUrl.Text + "\"," +
                                "\"type\":\"" + textBoxType.Text + "\"," +
                                "\"endpoint\":\"" + textBoxEndpoint.Text + "\"," +
                                "\"price\":" + textBoxPrice.Text +
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
    }
}
