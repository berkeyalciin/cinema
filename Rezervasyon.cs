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
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Green;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Green;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
