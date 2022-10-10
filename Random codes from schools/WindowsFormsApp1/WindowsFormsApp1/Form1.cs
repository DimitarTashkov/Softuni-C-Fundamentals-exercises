using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = int.Parse(textBox1.Text);
            switch (day)
            {
                case 1: label1.Text = "Monday";break;
                case 2: label1.Text = "Tuesday"; break;
                case 3: label1.Text = "Wednesday"; break;
                case 4: label1.Text = "Thursday"; break;
                case 5: label1.Text = "Friday"; break;
                case 6: label1.Text = "Saturday"; break;
                case 7: label1.Text = "Sunday"; break;
                default: label1.Text = "Error";
                    label1.Font = new Font(label1.Font, FontStyle.Bold); break;
            }
        } 
    }
}
