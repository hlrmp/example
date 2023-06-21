using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meraki_POS_System
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
            //DBConnection 
            SqlConnection dbConnectString = new SqlConnection(dbConn.getConnection());
        }
        //CLASSNAME FOR DATABASE CONNECTION
        dbConnections dbConn = new dbConnections();
        //COMMAND
        SqlCommand command = new SqlCommand();

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to cancel?", " ", MessageBoxButtons.YesNo);
            {
                ProductNameTextbox.Clear();
                CategoryNameTextBox.Clear();

            }
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ProductNameTextbox.Text) || String.IsNullOrEmpty(CategoryNameTextBox.Text))
            {
                MessageBox.Show("Fill in the Blank");
            }
            else
            {




            }
        }
    }
}
