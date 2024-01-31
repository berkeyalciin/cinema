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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace cinema1
{
    public partial class Detaylar : Form
    {
        private Image receivedImage;
        private String receivedName;
        private List<TimeSpan> times;
        private String description;

        public Detaylar(Image image, String name)
        {
            InitializeComponent();
            receivedImage = image;
            receivedName = name;

            pictureBox2.Image = receivedImage;
            times = new List<TimeSpan>();

            SqlConnection conn = DatabaseConnection.Instance.Connection;
            try
            {
                conn.Open();
                // Filtreleme işlemini WHERE kullanarak gerçekleştirin.
                string sqlQueryName = "SELECT SeansTime FROM Seanslar WHERE Film = @receivedName";
                using (SqlCommand command = new SqlCommand(sqlQueryName, conn))
                {
                    command.Parameters.AddWithValue("@receivedName", receivedName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TimeSpan seansTime = (TimeSpan)reader["SeansTime"];
                            times.Add(seansTime);
                        }
                    }
                }
                string sqlQueryDesc = "SELECT Aciklama FROM Filmler WHERE Name = @receivedName";
                using (SqlCommand command = new SqlCommand(sqlQueryDesc, conn))
                {
                    command.Parameters.AddWithValue("@receivedName", receivedName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            description = reader["Aciklama"].ToString();
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

            button2.Text = times[0].ToString("hh\\:mm");
            button3.Text = times[1].ToString("hh\\:mm");
            button4.Text = times[2].ToString("hh\\:mm");
            button5.Text = times[3].ToString("hh\\:mm");
            button6.Text = times[4].ToString("hh\\:mm");
        }

        private void Detaylar_Load(object sender, EventArgs e)
        {
            textBox1.Text = description;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Diğer forma geçiş
            Rezervasyon rez = new Rezervasyon();
            rez.Show();
            this.Hide();
        }
    }
}
