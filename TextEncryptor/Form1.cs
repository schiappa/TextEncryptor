using System;
using System.Diagnostics;
using System.Windows.Forms;
using TextEncryptor.Crypto;

namespace TextEncryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            //Hide messages
            ResultMsgLabel.Hide();

            //Center titles
            if (MainTitle.Parent != null)
                MainTitle.Left = (MainTitle.Parent.Width - MainTitle.Width) / 2;

            if (KeyTitle.Parent != null)
                KeyTitle.Left = (KeyTitle.Parent.Width - KeyTitle.Width) / 2;

            if (MainText.Parent != null)
                MainText.Left = (MainText.Parent.Width - MainText.Width) / 2;

            if (KeyText.Parent != null)
                KeyText.Left = (KeyText.Parent.Width - KeyText.Width) / 2;
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string text = MainText.Text;
                string keyCode = KeyText.Text;
                KeyServer key = new KeyServer();
                ReturnResultAndCopy(key.EncryptText(text, keyCode));
                ShowMessageForSeconds("👍 Copied to clipboard!", System.Drawing.Color.Green, 2000);
            }
            catch (Exception)
            {
                ShowMessageForSeconds("⚠ Error!", System.Drawing.Color.DarkRed, 2000);
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string text = MainText.Text;
                string keyCode = KeyText.Text;
                KeyServer key = new KeyServer();
                ReturnResultAndCopy(key.DecryptText(text, keyCode));
                ShowMessageForSeconds("👍 Copied to clipboard!", System.Drawing.Color.Green, 2000);
            }
            catch (Exception)
            {
                ShowMessageForSeconds("⚠ Error!", System.Drawing.Color.DarkRed, 2000);
            }
        }

        private void ReturnResultAndCopy(string text)
        {
            MainText.Text = text;
            Clipboard.SetText(text);
        }

        private void ShowMessageForSeconds(string text, System.Drawing.Color color, int milliseconds)
        {
            try
            {
                ResultMsgLabel.Text = text;
                ResultMsgLabel.ForeColor = color;
                if (ResultMsgLabel.Parent != null)
                    ResultMsgLabel.Left = (ResultMsgLabel.Parent.Width - ResultMsgLabel.Width) / 2;

                ResultMsgLabel.Show();

                Timer t = new Timer()
                {
                    Interval = milliseconds
                };
                t.Tick += (s, e) =>
                {
                    ResultMsgLabel.Hide();
                    t.Stop();
                };
                t.Start();
            }
            catch (Exception)
            {

            }
        }

        private void SupportBtn_Click(object sender, EventArgs e)
        {
            string command = "mailto:" + "santiago.chiappa@gmail.com" + $"?subject=Mensaje sobre Text Encryptor" + "&body=Por favor, escriba aquí su mensaje, consulta o sugerencia sobre el programa Text Encryptor. Sea claro y escriba todos los detalles que considere necesarios.";
            Process.Start(command);
        }
    }
}
