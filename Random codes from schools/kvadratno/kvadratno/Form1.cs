using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvadratno
{
    public partial class Уравнение : Form
    {
        public Уравнение()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double D;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            double x1;
            double x2;
            D = b * b - 4 * a * c;
            label5.Text = D.ToString();
            if (D<0)
            {
                label7.Text = "Няма реални корени";
            }
            else if (D==0)
            {
                x1 = (-b + Math.Sqrt(D) / 2 * a);
                label7.Text = "Уравнението има двоен корен";
                label8.Text = x1.ToString();

            }
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D) / (2 * a));
                x2 = (-b - Math.Sqrt(D) / (2 * a));
                label7.Text = x1.ToString();
                label8.Text = x2.ToString();

            }


        }
    }
}
