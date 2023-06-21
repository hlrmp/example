using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meraki_POS_System
{
    public partial class CategoryPanel : Form
    {
        //string dbConnectString = ("Data Source = LIYAN\\SQLEXPRESS; Initial Catalog = Finals; Integrated Security = True");

        public CategoryPanel()
        {
            InitializeComponent();
            //DBConnection 
            SqlConnection dbConnectString = new SqlConnection(dbConn.getConnection());
        }
        //CLASSNAME FOR DATABASE CONNECTION
        dbConnections dbConn = new dbConnections();
        //COMMAND
        SqlCommand command = new SqlCommand();
        //READER
        SqlDataReader reader;

        public void getCategory()
        {
            SqlConnection connection = new SqlConnection(dbConn.getConnection());
            connection.Open();

            string displayQuery = @"SELECT * From tblCategory";
            command = new SqlCommand(displayQuery, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtCategory.DataSource = dt;

            connection.Close();


            /*using (SqlConnection sqlConnect = new SqlConnection(dbConn.getConnection()))
            {
                sqlConnect.Open();
                string display = @"SELECT * From tblCategory";

                using (SqlCommand command = new SqlCommand(display, sqlConnect))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dtCategory.Rows.Add(reader["Category_ID"].ToString(), reader["Category_Name"].ToString());
                        }
                        reader.Close();
                    }
                }
                sqlConnect.Close();
            }*/
        }



        private void CategoryPanel_Load_1(object sender, EventArgs e)
        {
            //FOR DISPLAY DATA ON DATAGRID
            getCategory();
            
            /*using (SqlConnection sqlConnect = new SqlConnection(dbConn.getConnection()))
            {
                dtCategory.Rows.Clear();
                sqlConnect.Open();
                string display = @"SELECT Category_ID, Category_Name From tblCategory";

                using (SqlCommand command = new SqlCommand(display, sqlConnect))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dtCategory.Rows.Add(reader["Category_ID"].ToString(), reader["Category_Name"].ToString());
                        }
                        reader.Close();
                    }
                }
                sqlConnect.Close();
            }*/
        }

        private void dtCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //UPDATE OR EDIT
            if (dtCategory.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                string CategoryName;
                int CategoryID;
                CategoryID = Convert.ToInt32(dtCategory.Rows[e.RowIndex].Cells["CategoryID"].Value);
                CategoryName = Convert.ToString(dtCategory.Rows[e.RowIndex].Cells["CategoryName"].Value);

                EditCategory editCategoryFrm = new EditCategory(CategoryID, CategoryName);
                editCategoryFrm.ShowDialog();

                getCategory();
            }


            //DELETE 
            if (dtCategory.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult warning = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (warning == DialogResult.Yes)
                {
                    int CategoryID;
                    CategoryID = Convert.ToInt32(dtCategory.Rows[e.RowIndex].Cells["CategoryID"].Value);

                    SqlConnection connection = new SqlConnection(dbConn.getConnection());
                    connection.Open();

                    string deleteQuery = "DELETE FROM tblCategory WHERE Category_ID = @code";
                    command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@code", CategoryID);
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Deleted.");
                    }

                    connection.Close();
                    getCategory();
                }
                /*string CategoryID;
                CategoryID = Convert.ToString(dtCategory.Rows[e.RowIndex].Cells[0].Value);
                EditCategory editCategory = new EditCategory(CategoryID);
                editCategory.ShowDialog();*/

            }


        }

        private void CategoryPanel_Activated(object sender, EventArgs e)
        {
            getCategory();
        }

        private void dtCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
