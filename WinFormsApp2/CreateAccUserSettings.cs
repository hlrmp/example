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




namespace Meraki_POS_System
{
    public partial class CreateAccUserSettings : Form
    {



        public CreateAccUserSettings(string connectionString)
        {
            InitializeComponent();
        }


        private void cancel_create_button_Click(object sender, EventArgs e)
        {


            DialogResult choice = MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                //position_create_comboBox.Items.Cast<string>().ToList().Clear();
                position_create_comboBox.SelectedIndex = 0;
                name_create_text.Clear();
                usernm_create_text.Clear();
                passwrd_create_text.Clear();
                contactnum_create_text.Clear();
            }
        }

        private void position_create_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void CreateAccUserSettings_Load(object sender, EventArgs e)
        {

            ArrayList position = new ArrayList();
            position.Add("");
            position.Add("Admin");
            position.Add("Cashier");
            position_create_comboBox.Items.AddRange(position.ToArray());
            Console.WriteLine(position);

        }
        private void enter_create_button_Click(object sender, EventArgs e)
        {

            }





        }
    }


