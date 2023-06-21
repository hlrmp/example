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
    public partial class EditSupplier : Form
    {
        public EditSupplier()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                SupplierNameTextBox.Clear();
                AddressTextbox.Clear();
                EmailTextBox.Clear();
                ContactNumTextBox.Clear();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
