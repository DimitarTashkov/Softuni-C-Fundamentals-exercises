using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samolet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int hours = int.Parse(s);
            s = textBox2.Text;
            int minutes = int.Parse(s);
            s = textBox3.Text;
            int x = int.Parse(s);
            int allminutes = hours * 60 + minutes + x;
            int newhours = allminutes / 60;
            int newminutes = newhours % 60;
            label4.Text = String.Format("Времето за кацане е {0}h {1}min", newhours, newminutes);
            
        }
    }
}
