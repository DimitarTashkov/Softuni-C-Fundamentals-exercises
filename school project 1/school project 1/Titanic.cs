﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_project_1
{
    public partial class Titanic : Form
    {
        public Titanic()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form1 formOpener = new Form1();
            formOpener.Show();
            this.Close();
        }
    }
}
