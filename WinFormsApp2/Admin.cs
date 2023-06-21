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
    public partial class Admin : Form
    {
        //private const string connectionString = "Data Source=LIYAN\\SQLEXPRESS;Initial Catalog=MerakiFinalDB;Integrated Security=True ID=myUsername;Password=myPassword";
        public Admin()
        {
            InitializeComponent();
            Dashboard_button.MouseEnter += Dashboard_MouseEnter;
            Dashboard_button.MouseLeave += Dashboard_MouseLeave;
            ProductM_button.MouseEnter += ProductM_MouseEnter;
            ProductM_button.MouseLeave += ProductM_MouseLeave;
            Inventory_button1.MouseEnter += Inventory_MouseEnter;
            Inventory_button1.MouseLeave += Inventory_MouseLeave;
            Supplier_button.MouseEnter += Supplier_MouseEnter;
            Supplier_button.MouseLeave += Supplier_MouseLeave;
            SalesRep_button.MouseEnter += Sales_MouseEnter;
            SalesRep_button.MouseLeave += Sales_MouseLeave;
            UserSet_button.MouseEnter += UserSet_MouseEnter;
            UserSet_button.MouseLeave += UserSet_MouseLeave;

        }
        //Dashboard
        private void Dashboard_MouseEnter(object sender, EventArgs e)
        {
            Dashboard_button.Font = new Font(Dashboard_button.Font, FontStyle.Underline);
            Dashboard_button.BackColor = Color.CadetBlue;
        }
        private void Dashboard_MouseLeave(object sender, EventArgs e)
        {
            Dashboard_button.Font = new Font(Dashboard_button.Font, FontStyle.Regular);
            Dashboard_button.BackColor = Color.Transparent;
        }
        //Product Management
        private void ProductM_MouseEnter(object sender, EventArgs e)
        {
            ProductM_button.Font = new Font(ProductM_button.Font, FontStyle.Underline);
            ProductM_button.BackColor = Color.CadetBlue;
        }
        private void ProductM_MouseLeave(object sender, EventArgs e)
        {
            ProductM_button.Font = new Font(ProductM_button.Font, FontStyle.Regular);
            ProductM_button.BackColor = Color.Transparent;
        }
        //Inventory
        private void Inventory_MouseEnter(object sender, EventArgs e)
        {
            Inventory_button1.Font = new Font(Inventory_button1.Font, FontStyle.Underline);
            Inventory_button1.BackColor = Color.CadetBlue;
        }
        private void Inventory_MouseLeave(object sender, EventArgs e)
        {
            Inventory_button1.Font = new Font(Inventory_button1.Font, FontStyle.Regular);
            Inventory_button1.BackColor = Color.Transparent;
        }
        //Supplier
        private void Supplier_MouseEnter(object sender, EventArgs e)
        {
            Supplier_button.Font = new Font(Supplier_button.Font, FontStyle.Underline);
            Supplier_button.BackColor = Color.CadetBlue;
        }
        private void Supplier_MouseLeave(object sender, EventArgs e)
        {
            Supplier_button.Font = new Font(Supplier_button.Font, FontStyle.Regular);
            Supplier_button.BackColor = Color.Transparent;
        }
        //Sales Report  SalesRep_button
        private void Sales_MouseEnter(object sender, EventArgs e)
        {
            SalesRep_button.Font = new Font(SalesRep_button.Font, FontStyle.Underline);
            SalesRep_button.BackColor = Color.CadetBlue;
        }
        private void Sales_MouseLeave(object sender, EventArgs e)
        {
            SalesRep_button.Font = new Font(SalesRep_button.Font, FontStyle.Regular);
            SalesRep_button.BackColor = Color.Transparent;
        }
        //user settings
        private void UserSet_MouseEnter(object sender, EventArgs e)
        {
            UserSet_button.Font = new Font(UserSet_button.Font, FontStyle.Underline);
            UserSet_button.BackColor = Color.CadetBlue;
        }
        private void UserSet_MouseLeave(object sender, EventArgs e)
        {
            UserSet_button.Font = new Font(UserSet_button.Font, FontStyle.Regular);
            UserSet_button.BackColor = Color.Transparent;
        }





        private void SalesHIstory_Button_Click(object sender, EventArgs e)
        {
            SalesReport salesHistory = new SalesReport();
            salesHistory.TopLevel = false;
            panel2.Controls.Add(salesHistory);
            salesHistory.BringToFront();
            salesHistory.Show();
        }


        private void Dashboard_button_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.TopLevel = false;
            panel2.Controls.Add(dashboard);
            dashboard.BringToFront();
            dashboard.Show();
        }

        private void ProductM_button_Click(object sender, EventArgs e)
        {
            ProductManagement productList = new ProductManagement();
            productList.TopLevel = false;
            panel2.Controls.Add(productList);
            productList.BringToFront();
            productList.Show();
        }

        private void Supplier_button_Click_1(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.TopLevel = false;
            panel2.Controls.Add(supplier);
            supplier.BringToFront();
            supplier.Show();
        }

        private void SalesRep_button_Click(object sender, EventArgs e)
        {
            SalesReport sales = new SalesReport();
            sales.TopLevel = false;
            panel2.Controls.Add(sales);
            sales.BringToFront();
            sales.Show();
        }

        private void UserSet_button_Click_1(object sender, EventArgs e)
        {
            UserSettings userSettings = new UserSettings();
            userSettings.TopLevel = false;
            panel2.Controls.Add(userSettings);
            userSettings.BringToFront();
            userSettings.Show();

        }
        private void Inventory_button1_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.TopLevel = false;
            panel2.Controls.Add(inventory);
            inventory.BringToFront();
            inventory.Show();
        }
        private void logout_button_Click(object sender, EventArgs e)
        {


            DialogResult choices = MessageBox.Show("Are you sure you want to logout? ", "", MessageBoxButtons.YesNo);
            if (choices == DialogResult.Yes)
            {
                LoginAccount loginAccount = new LoginAccount();
                loginAccount.Show();
                this.Close();

            }


        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

