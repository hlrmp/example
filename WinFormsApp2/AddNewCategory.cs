using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Meraki_POS_System2;

namespace Meraki_POS_System
{
    public partial class AddNewCategory : Form
    {
        int categID;
        string categName;
        public AddNewCategory()
        {
            InitializeComponent();
            //DBConnection 
            SqlConnection dbConnectString = new SqlConnection(dbConn.getConnection());
            CategoryPanel categoryPanel = new CategoryPanel();
        }
        //CLASSNAME FOR DATABASE CONNECTION
        dbConnections dbConn = new dbConnections();
        //COMMAND
        SqlCommand command = new SqlCommand();

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to cancel?", " ", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes) 
            {
                CategoryNameTextBox.Clear();

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string addCategName = CategoryNameTextBox.Text;
            SqlConnection connection = new SqlConnection(dbConn.getConnection());  
            CategoryPanel cp = new CategoryPanel();
            cp.getCategory();
            connection.Open();




            string addQuery = "INSERT INTO tblCategory(Category_Name) VALUES(@Category_Name)";
            command = new SqlCommand(addQuery, connection);
            command.Parameters.AddWithValue("@Category_Name", addCategName);
            command.ExecuteNonQuery();
            string AddCategName = addCategName;
            this.Close();

            connection.Close();

            MessageBox.Show("Saved Successfully!");
            CategoryNameTextBox.Clear();
  

        }






        private void AddNewCategory_Load(object sender, EventArgs e)
        {
            CategoryPanel cp = new CategoryPanel();
            cp.getCategory();
        }

        private void AddNewCategory_Click(object sender, EventArgs e)
        {
            CategoryPanel cp = new CategoryPanel();
            cp.getCategory();
        }

        private void AddNewCategory_Activated(object sender, EventArgs e)
        {
            CategoryPanel cp = new CategoryPanel();
            cp.getCategory();
        }
    }
}







