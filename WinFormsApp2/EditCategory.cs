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
    public partial class EditCategory : Form
    {
        //string dbConnectString = ("Data Source = LIYAN\\SQLEXPRESS; Initial Catalog = Finals; Integrated Security = True");
        int categID;
        string categName;
        public EditCategory(int CategoryID, string CategoryName)
        {
            InitializeComponent();
            categID = CategoryID;
            categName = CategoryName;
            //DBConnection 
            SqlConnection dbConnectString = new SqlConnection(dbConn.getConnection());

        }
        //CLASSNAME FOR DATABASE CONNECTION
        dbConnections dbConn = new dbConnections();
        //COMMAND
        SqlCommand command = new SqlCommand();


        private void EditCategory_Load(object sender, EventArgs e)
        {
            categName = EditCategoryNameTextBox.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            categName = EditCategoryNameTextBox.Text;

            SqlConnection connection = new SqlConnection(dbConn.getConnection());
            connection.Open();

            string updateQuery = "UPDATE tblCategory SET Category_Name = @Category_Name WHERE Category_ID = '" + categID + "' ";
            command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@Category_Name", categName);
            int result = command.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Data Updated Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Data Not Updated.");
            }
            
            connection.Close();
            CategoryPanel cp = new CategoryPanel();
            cp.getCategory();

            /*string CategName = EditCategoryNameTextBox.Text;


            CategoryPanel cp = new CategoryPanel();

            using (SqlConnection sqlConnect = new SqlConnection(dbConn.getConnection()))
            {
                sqlConnect.Open();
                string query = "UPDATE tblCategory SET Category_Name = @Category_Name WHERE Category_ID = '" + categID + "' ";
                SqlCommand cmd = new SqlCommand(query, sqlConnect);
                cmd.Parameters.AddWithValue("@Category_Name", CategName);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Edited Successfully!");
                cp.getCategory();
                 
                sqlConnect.Close();

            }*/
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to cancel?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                EditCategoryNameTextBox.Clear();
            }
            
        }
    }
}
