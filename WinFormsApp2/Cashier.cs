using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meraki_POS_System
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            SelectedProducts.RowHeadersVisible = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            DialogResult choices = MessageBox.Show("Are you sure you want to logout? ", "", MessageBoxButtons.YesNo);
            if (choices == DialogResult.Yes)
            {
                LoginAccount loginAccount = new LoginAccount();
                loginAccount.Show();
                this.Close();

            }


        }
    }
}
