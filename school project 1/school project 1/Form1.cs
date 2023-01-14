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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BestSellerscs bestSeller = new BestSellerscs();
            bestSeller.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int choice = random.Next(1, 5);
            switch(choice)
            {
                case 1: Avatar avatar = new Avatar();
                    avatar.Show();
                    break;
                case 2:
                    Avengers avengers = new Avengers();
                    avengers.Show();
                    break;
                case 3:
                    Fast_and_Furious faf = new Fast_and_Furious();
                    faf.Show();
                    break;
                case 4:
                    Jurassic jurassic = new Jurassic();
                    jurassic.Show();
                    break;
                case 5:
                    Titanic titanic = new Titanic();
                    titanic.Show();
                    break;
            }
        }
    }
}
