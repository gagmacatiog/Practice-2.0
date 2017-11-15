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
            rightPanel.Width = Convert.ToInt32(this.Size.Width * .3);
            topPanel.Height = Convert.ToInt32(this.Size.Height * .66);
            bottomRight.Width = Convert.ToInt32(topPanel.Width * .5);
            label1.Height = Convert.ToInt32(bottomRight.Height / 2);
            label1.Font = new Font(label1.Font.FontFamily, label1.Height / 4);
            label2.Font = new Font(label2.Font.FontFamily, label2.Height / 4);

            label3.Height = Convert.ToInt32(rightPanel.Height / 7);
            label3.Font = new Font(label3.Font.FontFamily, label3.Height / 4);
            

            label4.Height = label3.Height;
            label4.Font = new Font(label4.Font.FontFamily, label4.Height / 4);
            label5.Height = label3.Height;
            label5.Font = new Font(label5.Font.FontFamily, label5.Height / 4);
            label6.Height = label3.Height;
            label6.Font = new Font(label6.Font.FontFamily, label6.Height / 4);
            label7.Height = label3.Height;
            label7.Font = new Font(label7.Font.FontFamily, label7.Height / 4);
            label8.Height = label3.Height;
            label8.Font = new Font(label8.Font.FontFamily, label8.Height / 4);
            label9.Height = label3.Height;
            label9.Font = new Font(label9.Font.FontFamily, label9.Height / 4);

            label10.Height = Convert.ToInt32(topPanel.Height / 2);
            label10.Font = new Font(label10.Font.FontFamily, label10.Height / 5);
            label11.Font = new Font(label11.Font.FontFamily, label11.Height / 5);
            label12.Width = Convert.ToInt32(topPanel.Width / 3);
            label12.Font = new Font(label12.Font.FontFamily, label12.Height / 5);

            int height = Convert.ToInt32(bottomLeft.Height / 4);
            this.infoBox.AutoSize = false;
            this.infoBox.Size = new System.Drawing.Size(this.infoBox.Width, height);
            infoBox.Font = new Font(infoBox.Font.FontFamily, height / 2);

            this.comboBox1.AutoSize = false;
            this.comboBox1.Size = new System.Drawing.Size(this.comboBox1.Width, height);
            this.comboBox1.Font = new Font(comboBox1.Font.FontFamily, height / 2);

            qButton.Width = infoBox.Width / 2;
            qButton.Font = new Font(qButton.Font.FontFamily, qButton.Width / 10);
            gButton.Height = infoBox.Width / 2;
            gButton.Font = new Font(gButton.Font.FontFamily, gButton.Width / 10);

            //panel2.Width = Convert.ToInt32(this.Size.Width * .25);
            //panel3.Width = Convert.ToInt32(this.Size.Width * .25);
            //panel6.Height = Convert.ToInt32(this.Size.Height * .6);
            //panel5.Height = Convert.ToInt32(this.Size.Height * .4);
            //panel10.Height = Convert.ToInt32(panel2.Height * .5);
            //panel11.Height = panel10.Height;

            //button1.Width = 200;

            //label1.Font = new Font(label1.Font.OriginalFontName, 200);
            //label1.Height = panel5.Height;

            //label2.Font = new Font(label2.Font.OriginalFontName, 40);
            //label2.Height = 80;

            //label3.Font = new Font(label3.Font.OriginalFontName, 20);
            //label3.Height = 100;

            //label4.Font = new Font(label4.Font.OriginalFontName, 40);
            //label4.Height = 80;

            this.ActiveControl = qButton;
        }

        private void infoBox_Enter(object sender, EventArgs e)
        {
            if(infoBox.Text == "ID Number or Guest Name")
            {
                infoBox.Text = "";

                infoBox.ForeColor = Color.Black;
            }
        }
        
        private void infoBox_Leave(object sender, EventArgs e)
        {
            if(infoBox.Text == "")
            {
                infoBox.Text = "ID Number or Guest Name";

                infoBox.ForeColor = Color.Silver;
            }else
            {

            }
        }
    }
}
