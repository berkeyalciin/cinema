using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            List<string> imagePaths = new List<string>();
            List<string> names = new List<string>();
            SqlConnection conn = DatabaseConnection.Instance.Connection;
            try
            {
                conn.Open();
                string sqlQuery = "SELECT Resim from Filmler";
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string img = reader["Resim"].ToString();
                            img = Path.Combine(img);
                            imagePaths.Add(img);
                        }
                    }
                }
                string sqlQueryName = "SELECT Name from Filmler";
                using (SqlCommand command = new SqlCommand(sqlQueryName, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            names.Add(name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            this.pictureBox5.Image = Image.FromFile(imagePaths[0]);
            this.pictureBox5.Name = names[0];
            this.pictureBox6.Image = Image.FromFile(imagePaths[1]);
            this.pictureBox6.Name = names[1];
            this.pictureBox7.Image = Image.FromFile(imagePaths[2]);
            this.pictureBox7.Name = names[2];
            this.pictureBox8.Image = Image.FromFile(imagePaths[3]);
            this.pictureBox8.Name = names[3];
            this.pictureBox3.Image = Image.FromFile(imagePaths[4]);
            this.pictureBox3.Name = names[4];
            this.pictureBox2.Image = Image.FromFile(imagePaths[5]);
            this.pictureBox2.Name = names[5];
            this.pictureBox1.Image = Image.FromFile(imagePaths[6]);
            this.pictureBox1.Name = names[6];
            this.pictureBox4.Image = Image.FromFile(imagePaths[7]);
            this.pictureBox4.Name = names[7];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //troller

            // PictureBox'ın tag özelliği üzerinden resmin dosya yolunu al
            Image selectedImage = pictureBox2.Image;
            String selectedName = pictureBox2.Name;

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
