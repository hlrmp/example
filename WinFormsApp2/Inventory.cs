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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = " ";
            editButton.Name = "editButton";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            inventory_datagrid.Columns.Add(editButton);
            inventory_datagrid.CellFormatting += inventory_datagrid_CellFormatting;

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = " ";
            deleteButton.Name = "deleteButton";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            inventory_datagrid.Columns.Add(deleteButton);
            inventory_datagrid.CellFormatting += inventory_datagrid_CellFormatting;
        }

        private void inventory_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                edit_inventory edit_Inventory = new edit_inventory();
                edit_Inventory.Show();
            }

            if (e.ColumnIndex == 7)
            {
                MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo);
            }

        }

        private void inventory_datagrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == inventory_datagrid.Columns["editButton"].Index)
                {
                    e.Value = "Edit";
                }
                else if (e.ColumnIndex == inventory_datagrid.Columns["deleteButton"].Index)
                {
                    e.Value = "Delete";
                }
            }
        }
    }
}
