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
    public partial class Detaylar : Form
    {
        private Image receivedImage;
        public Detaylar(Image image)
        {
            InitializeComponent();
            receivedImage = image;

            pictureBox2.Image = receivedImage;
        }

        private void Detaylar_Load(object sender, EventArgs e)
        {

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
