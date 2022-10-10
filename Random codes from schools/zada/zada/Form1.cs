using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zada
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
            double bel_izpit, mat_izpit, bel_dipl, mat_dipl, ezik_dipl;
            double rezultat;

            bel_izpit = double.Parse(textBox1.Text);
            mat_izpit = double.Parse(textBox4.Text);
            bel_dipl = double.Parse(textBox2.Text);
            mat_dipl = double.Parse(textBox3.Text);
            ezik_dipl = double.Parse(textBox5.Text);
            bel_dipl = double.Parse(textBox2.Text);
            rezultat = bel_izpit + mat_izpit * 2 + bel_dipl + mat_dipl + ezik_dipl;
            if (rezultat < 21)
            {
                label12.Text = "Не сте класиран";
            }
            else if (rezultat <= 25)
            {
                label12.Text = "Технологичен";
            }
            else if (rezultat <= 29)
            {
                label12.Text = "Софтуерни и хардуерни науки";
            }
            else label12.Text = "Математическа";
        }
    }
}
