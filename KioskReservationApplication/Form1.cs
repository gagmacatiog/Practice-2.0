using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskReservationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Width = Convert.ToInt32(this.Size.Width * .25);
            panel3.Width = Convert.ToInt32(this.Size.Width * .25);
            panel6.Height = Convert.ToInt32(this.Size.Height * .6);
            panel5.Height = Convert.ToInt32(this.Size.Height * .4);
            panel10.Height = Convert.ToInt32(panel2.Height * .5);
            panel11.Height = panel10.Height;

            button1.Width = 200;

            label1.Font = new Font(label1.Font.OriginalFontName, 200);
            label1.Height = panel5.Height;

            label2.Font = new Font(label2.Font.OriginalFontName, 40);
            label2.Height = 80;

            label3.Font = new Font(label3.Font.OriginalFontName, 20);
            label3.Height = 100;

            label4.Font = new Font(label4.Font.OriginalFontName, 40);
            label4.Height = 80;

            this.ActiveControl = label1;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "ID Number")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "ID Number";

                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Name")
            {
                textBox2.Text = "";

                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Name";

                textBox2.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
