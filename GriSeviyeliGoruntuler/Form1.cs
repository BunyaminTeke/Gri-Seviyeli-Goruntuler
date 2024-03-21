namespace GriSeviyeliGoruntuler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_resimyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "Resim dosyalarý (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif|Tüm dosyalar (*.*)|*.*";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            pictureBox1.ImageLocation = sfd.FileName;
        }

        private void btn_griyap_Click(object sender, EventArgs e)
        {

            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = griYap(image);
            pictureBox2.Image = gri;
        }

        private Bitmap griYap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {

                    int deger = (bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j, i).B) / 3;

                    Color renk;

                    renk = Color.FromArgb(deger, deger, deger);
                    bmp.SetPixel(j, i, renk);

                }
            }

            return bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image2 = new Bitmap(pictureBox1.Image);
            Bitmap binary = binaryYap(image2);

            pictureBox2.Image = binary;
        }
        private Bitmap binaryYap(Bitmap image)
        {
            Bitmap gri = griYap(image);
            int esik = 100;
            int temp = 0;
            Color renk;
            for (int i = 0; i < image.Height - 1; i++)
            {
                for (int j = 0; j < image.Width - 1; j++)
                {
                    temp = gri.GetPixel(j, i).R;

                    if (temp < esik)
                    {
                        renk = Color.FromArgb(0, 0, 0);
                        gri.SetPixel(j, i, renk);
                    }
                    else
                    {
                        renk = Color.FromArgb(255, 255, 255);
                        gri.SetPixel(j, i, renk);
                    }
                }
            }

            return gri;
        }

    }
}
