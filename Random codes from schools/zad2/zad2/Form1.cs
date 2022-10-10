using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int x = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int total = a + b + c + d + x + f;
            textBox7.Text = total.ToString();
            if (a > 10 || a < 0)
            {
                this.Close();
            }
            else if (b > 10 || b < 0)
            {
                this.Close();
            }
            else if (c > 10 || c < 0)
            {
                this.Close();
            }
            else if (d > 10 || d < 0)
            {
                this.Close();
            }
            else if (x > 10 || x < 0)
            {
                this.Close();
            }
            else if (f > 10 || f < 0)
            {
                this.Close();
            }
            if (total >= 40)
            {
                listBox1.Items.Add("Вие сте отличен кандидат за програмист. Препоръчваме ви да запишете курс по програмиране");
            }
            else if (total > 20 && total < 40)
            {
                listBox1.Items.Add("Интересът ви към програмирането е несигурен. Може би трябва да запишете курс за да научите повече");
            }
            else if (total <= 20)
            {
                listBox1.Items.Add("Трябва да изберете друг път за професионално развитие. Програмирането може би не е за вас.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            listBox1.Items.Clear();
        }
    }
}
