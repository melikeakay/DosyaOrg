using System.Drawing.Text;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DosyaOrganizasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _password = "Password2123";
        
        OpenFileDialog dialog = new OpenFileDialog();
        private void Dosyabutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
                using(StreamReader sr = new StreamReader(textBox1.Text))
                {
                    textBox2.Text = sr.ReadToEnd();
                }

            }
        }

        private void Sifrebutton_Click(object sender, EventArgs e)
        {
            byte[] salt = GenerateSalt();
            var localLink= textBox1.Text.Split('.')[0]+"aes";
            FileStream fs = new FileStream(localLink, FileMode.Create);
            byte[] passwordBytes = Encoding.Unicode.GetBytes(_password);

            RijndaelManaged aes = new RijndaelManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Padding=PaddingMode.PKCS7;

            var key = new Rfc2898DeriveBytes(passwordBytes,salt,50);
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.KeySize / 16);
            aes.Mode=CipherMode.CFB;
            fs.Write(salt,0,salt.Length);

            //textBox2.Text = Path.GetFileName(dialog.FileName);
            CryptoStream cs=new CryptoStream(fs,aes.CreateEncryptor(),CryptoStreamMode.Write);
            FileStream fsIn = new FileStream(textBox2.Text, FileMode.OpenOrCreate);
            byte[] buffer = new byte[108576];
            int read;
            try
            {
                while((read=fsIn.Read(buffer,0,buffer.Length)) > 0)
                {
                    fsIn.Write(buffer,0,read);
                }
            }
            catch (CryptographicException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
                fsIn.Close();
                using(StreamReader sr = new StreamReader(localLink))
                {
                    textBox3.Text=sr.ReadToEnd();
                }

                if (File.Exists(textBox3.Text))
                {
                    File.Delete(textBox3.Text);
                    textBox2.Text=String.Empty;
                }
            }
         
        }

        private byte[] GenerateSalt()
        {
            byte[] data = new byte[32];
            using (RNGCryptoServiceProvider rgn =new RNGCryptoServiceProvider())
            {
                for(int i = 0; i < 10; i++)
                    rgn.GetBytes(data);
                return data;   
                
            }
        }

        
    }
}