using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int car = int.Parse(textBox1.Text);
            switch (car)
            {
                case 1:
                    label3.Text = "car1";
                    pictureBox1.Image = Properties.Resources.zadacha; break;
                case 2:
                    label3.Text = "car2";
                    pictureBox1.Image = Properties.Resources.zadacha2; break;
                case 3:
                    label3.Text = "car3";
                    pictureBox1.Image = Properties.Resources.zadacha3; break;
                case 4:
                    label3.Text = "car4";
                    pictureBox1.Image = Properties.Resources.zadacha4; break;
                case 5:
                    label3.Text = "car5";
                    pictureBox1.Image = Properties.Resources.zadacha5; break;
                case 6:
                    label3.Text = "car6";
                    pictureBox1.Image = Properties.Resources.zadacha6; break;
                case 7:
                    label3.Text = "car7";
                    pictureBox1.Image = Properties.Resources.zadacha7; break;
                case 8:
                    label3.Text = "car8";
                    pictureBox1.Image = Properties.Resources.zadacha8; break;
                case 9:
                    label3.Text = "car9";
                    pictureBox1.Image = Properties.Resources.zadacha9; break;
            }
        }
    }
}
