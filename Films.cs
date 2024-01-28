using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema1
{
    public partial class Films : Form
    {
        public Films()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //troller

            // PictureBox'ın tag özelliği üzerinden resmin dosya yolunu al
            Image selectedImage = pictureBox2.Image;
            String selectedName = pictureBox2.Name;

            Console.WriteLine(selectedName);

            // Diğer forma geçiş
            Detaylar detaylar = new Detaylar(selectedImage, selectedName);
            detaylar.Show();
            this.Hide(); 

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //atatürk

            // PictureBox'ın tag özelliği üzerinden resmin dosya yolunu al
            Image selectedImage = pictureBox3.Image;
            String selectedName = pictureBox3.Name;

            // Diğer forma geçiş
            Detaylar detaylar = new Detaylar(selectedImage, selectedName);
            detaylar.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //marvel

            // PictureBox'ın tag özelliği üzerinden resmin dosya yolunu al
            Image selectedImage = pictureBox1.Image;
            String selectedName = pictureBox1.Name;

            // Diğer forma geçiş
            Detaylar detaylar = new Detaylar(selectedImage, selectedName);
            detaylar.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //freddy

            // PictureBox'ın tag özelliği üzerinden resmin dosya yolunu al
            Image selectedImage = pictureBox4.Image;
            String selectedName = pictureBox4.Name;

            // Diğer forma geçiş
            Detaylar detaylar = new Detaylar(selectedImage, selectedName);
            detaylar.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //saw

            // PictureBox'ın tag özelliği üzerinden resmin dosya yolunu al
            Image selectedImage = pictureBox5.Image;
            String selectedName = pictureBox5.Name;

            // Diğer forma geçiş
            Detaylar detaylar = new Detaylar(selectedImage, selectedName);
            detaylar.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //senigoruyorum

            // PictureBox'ın tag özelliği üzerinden resmin dosya yolunu al
            Image selectedImage = pictureBox6.Image;
            String selectedName = pictureBox6.Name;

            // Diğer forma geçiş
            Detaylar detaylar = new Detaylar(selectedImage, selectedName);
            detaylar.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //vatikan

            // PictureBox'ın tag özelliği üzerinden resmin dosya yolunu al
            Image selectedImage = pictureBox7.Image;
            String selectedName = pictureBox7.Name;

            // Diğer forma geçiş
            Detaylar detaylar = new Detaylar(selectedImage, selectedName);
            detaylar.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //cokask

            // PictureBox'ın tag özelliği üzerinden resmin dosya yolunu al
            Image selectedImage = pictureBox8.Image;
            String selectedName = pictureBox8.Name;

            // Diğer forma geçiş
            Detaylar detaylar = new Detaylar(selectedImage,selectedName);
            detaylar.Show();
            this.Hide();
        }
    }
}
