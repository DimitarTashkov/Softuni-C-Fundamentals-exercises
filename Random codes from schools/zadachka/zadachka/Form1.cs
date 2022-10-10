using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadachka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = int.Parse(textBox1.Text);
            double minuti = s / 60;
            double chasove = minuti / 60;
            double dni = chasove / 24;
            label1.Text = dni.ToString();
            label2.Text = chasove.ToString();
            label3.Text = minuti.ToString();
        }
    }
}
