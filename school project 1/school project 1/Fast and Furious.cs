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
    public partial class Fast_and_Furious : Form
    {
        public Fast_and_Furious()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form1 formOpen = new Form1();
            formOpen.Show();
            this.Close();
        }
    }
}
