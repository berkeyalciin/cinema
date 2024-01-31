using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema1
{
    public partial class Rezervasyon : Form
    {
        int SalonNo;
        List<int> KoltukDurumListesi = new List<int>();
        List<int> selectedSeats = new List<int>();
        public Rezervasyon(String seans, String name)
        {
            InitializeComponent();
            textBox1.TextAlign = HorizontalAlignment.Center;

            SqlConnection conn = DatabaseConnection.Instance.Connection;
            try
            {
                conn.Open();

                string sqlQuery = "SELECT SalonNumber FROM Seanslar WHERE Film = @name AND CONVERT(time, SeansTime) = CONVERT(time, @seans)";
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@seans", seans);

                    object result = command.ExecuteScalar();
                    SalonNo = Convert.ToInt32(result);
                }

                string sqlQueryKoltuk = "SELECT KoltukDurumu FROM Koltuklar WHERE SalonNo = @salonID";
                using (SqlCommand commandKoltuk = new SqlCommand(sqlQueryKoltuk, conn))
                {
                    commandKoltuk.Parameters.AddWithValue("@salonID", SalonNo);

                    using (SqlDataReader reader = commandKoltuk.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int koltukDurumu = Convert.ToInt32(reader["KoltukDurumu"]);
                            KoltukDurumListesi.Add(koltukDurumu);
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

            List<Button> butonlar = new List<Button>
            {
                button1, button2, button3, button4, button5, button6, button7, button8,
                button9, button10, button11, button12, button13, button14, button15, button16,
                button17, button18, button19, button20, button21, button22, button23, button24,
                button25, button26, button27, button28, button29, button30, button31, button32,
                button33, button34, button35, button36, button37, button38, button39, button40,
                button41, button42, button43, button44, button45, button46, button47, button48,
                button49, button50, button51, button52, button53, button54, button55, button56,
                button57, button58, button59, button60, button61, button62, button63, button64
            };

            for (int i = 0; i < butonlar.Count; i++)
            {

                if (KoltukDurumListesi[i] == 1)
                {
                    butonlar[i].BackColor = Color.Green;
                }
                else
                {
                    butonlar[i].BackColor = Color.White;
                }

                butonlar[i].Name = KoltukDurumListesi[i].ToString();
                butonlar[i].Tag = i + 1;
                butonlar[i].Click += new System.EventHandler(this.Button_Click);
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                clickedButton.BackColor = (clickedButton.BackColor == Color.Green) ? Color.White : Color.Green;

                int koltukIndex = (int)clickedButton.Tag;
                int koltukDurumu = KoltukDurumListesi[koltukIndex];

                if (selectedSeats.Contains(koltukIndex))
                {
                    selectedSeats.Remove(koltukIndex);
                }
                else
                {
                    selectedSeats.Add(koltukIndex);
                }
            }
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DatabaseConnection.Instance.Connection;

            try
            {
                conn.Open();

                foreach (int selectedSeat in selectedSeats)
                {
                    // Koltuklar tablosunda güncelleme işlemi yap
                    string sqlUpdate = "UPDATE Koltuklar SET KoltukDurumu = CASE WHEN KoltukDurumu = 1 THEN 0 ELSE 1 END WHERE SalonNo = @salonID AND ID = @koltukID";

                    using (SqlCommand commandUpdate = new SqlCommand(sqlUpdate, conn))
                    {
                        commandUpdate.Parameters.AddWithValue("@salonID", SalonNo);
                        commandUpdate.Parameters.AddWithValue("@koltukID", selectedSeat);

                        commandUpdate.ExecuteNonQuery();
                    }
                }

                selectedSeats.Clear();

                MessageBox.Show("Koltuk durumları güncellendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Bir hata oluştu. Koltuk durumları güncellenemedi.");
            }
            finally
            {
                conn.Close();
            }
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
