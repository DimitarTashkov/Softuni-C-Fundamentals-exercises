using System;
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
    public partial class BestSellerscs : Form
    {
        public BestSellerscs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                Avatar avatar = new Avatar();
                avatar.Show();
            }
            else if (radioButton2.Checked)
            {
                Avengers avengers = new Avengers();
                avengers.Show();
            }
            else if (radioButton3.Checked)
            {
                Fast_and_Furious faf = new Fast_and_Furious();
                faf.Show();
            }
            else if (radioButton4.Checked)
            {
                Jurassic jurassic = new Jurassic();
                jurassic.Show();
            }
            else if (radioButton5.Checked)
            {
                Titanic titanic = new Titanic();
                titanic.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
