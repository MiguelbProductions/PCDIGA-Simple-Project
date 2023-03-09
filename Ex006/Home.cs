using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex006
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ComputerBox_Click(object sender, EventArgs e)
        {
            new BuyItems("Computadores > Desktop").Show();

            this.Hide();
        }

        private void PhoneBox_Click(object sender, EventArgs e)
        {
            new BuyItems("Phones").Show();

            this.Hide();
        }

        private void HeaSetBox_Click(object sender, EventArgs e)
        {
            new BuyItems("HeadSets").Show();

            this.Hide();
        }
    }
}
