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
    public partial class Login : Form
    {
        private string username, password;
        public Login()
        {
            InitializeComponent();
            SqlConnection conn = DatabaseConnection.Instance.Connection;
            try
            {
                conn.Open();
                string sqlQuery = "SELECT username from Kullanicilar";
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            username = reader["username"].ToString();
                        }
                    }
                }
                string sqlQueryPassword = "SELECT password from Kullanicilar";
                using (SqlCommand command = new SqlCommand(sqlQueryPassword, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            password = reader["password"].ToString();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kullaniciAdi = textBox1.Text;
            String sifre = textBox2.Text;

            if (kullaniciAdi == username && sifre == password)
            {
                Films films = new Films();
                films.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Başarısız!");
            
        }
    }
}
