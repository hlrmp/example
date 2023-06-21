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
    public partial class EditProductList : Form
    {
        public EditProductList()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to cancel?", " ", MessageBoxButtons.YesNo);
            {
                ProductNameTextbox.Clear();
                PriceTextBox.Clear();

            }
        }
    }
}
