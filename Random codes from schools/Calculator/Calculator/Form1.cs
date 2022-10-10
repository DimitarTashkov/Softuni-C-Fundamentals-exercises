using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int plus = a - b;
            textBox3.Text = plus.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = button1.Text;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int plus = a + b;
            textBox3.Text = plus.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = button3.Text;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int plus = a * b;
            textBox3.Text = plus.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = button4.Text;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int plus = a / b;
            textBox3.Text = plus.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
