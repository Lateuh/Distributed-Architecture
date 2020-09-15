using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP_WS_WF
{
    public partial class Form3 : Form
    {
        private String choix;
        private String refe;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(String choix)
        {
            InitializeComponent();
            this.choix = choix;
        }

        public Form3(String choix, String refe)
        {
            InitializeComponent();
            this.choix = choix;
            this.refe = refe;
        }

        

        private void buttonAffiche_Click(object sender, EventArgs e)
        {
            ServiceHotel.WebService1SoapClient SH = new ServiceHotel.WebService1SoapClient();
            String imgStr = SH.GetImg(choix);
            Byte[] imgByte = Convert.FromBase64String(imgStr);
            System.IO.MemoryStream imgStream = new System.IO.MemoryStream(imgByte,0,imgByte.Length);
            Image img = Image.FromStream(imgStream,true);
            img = ScaleImage(img, 900, 500);
            Graphics gr = this.CreateGraphics();
            gr.DrawImage(img,20,60);
        }

        public Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(maxWidth, maxHeight);
            using (var graphics = Graphics.FromImage(newImage))
            {
                // Calculate x and y which center the image
                int y = (maxHeight / 2) - newHeight / 2;
                int x = (maxWidth / 2) - newWidth / 2;

                // Draw image on x and y with newWidth and newHeight
                graphics.DrawImage(image, x, y, newWidth, newHeight);
            }

            return newImage;
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.refe))
            {
                MessageBox.Show("Pas de réservation effectuée.");
            }
            else
            {
                MessageBox.Show(this.refe);
            }
        }
    }
}
