namespace DosyaOrganizasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dosyabutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                label1.Text=dialog.FileName;
                textBox1.Text=dialog.FileName;
            }
        }

        private void Sifrebutton_Click(object sender, EventArgs e)
        {
            Byte[] dosya = File.ReadAllBytes(label1.Text);

            for(int i=0; i < dosya.Length; i++)
            {
                dosya[i]=(Byte)((int)dosya[i]+1);

                if (dosya[i] >255)
                {
                    dosya[i] = 0;
                }
            }
            File.WriteAllBytes(textBox1.Text, dosya);
        }

        private void cozbutton_Click(object sender, EventArgs e)
        {
            Byte[] dosya = File.ReadAllBytes(label1.Text);

            for (int i = 0; i < dosya.Length; i++)
            {
                

                if ((Byte)((int)dosya[i] + -1) < 0)
                {
                    dosya[i] = 255; 
                }
                else
                {
                    dosya[i] = (Byte)((int)dosya[i] + -1);
                }
            }
            File.WriteAllBytes(textBox1.Text, dosya);
        }
    }
}