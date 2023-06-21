namespace Meraki_POS_System
{
    partial class CategoryPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtCategory = new DataGridView();
            CategoryID = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dtCategory).BeginInit();
            SuspendLayout();
            // 
            // dtCategory
            // 
            dtCategory.AllowUserToAddRows = false;
            dtCategory.AllowUserToDeleteRows = false;
            dtCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtCategory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtCategory.BackgroundColor = Color.Gainsboro;
            dtCategory.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCategory.Columns.AddRange(new DataGridViewColumn[] { CategoryID, CategoryName, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtCategory.DefaultCellStyle = dataGridViewCellStyle2;
            dtCategory.GridColor = SystemColors.GrayText;
            dtCategory.Location = new Point(2, 0);
            dtCategory.Name = "dtCategory";
            dtCategory.ReadOnly = true;
            dtCategory.RowHeadersWidth = 62;
            dtCategory.RowTemplate.Height = 33;
            dtCategory.Size = new Size(1046, 367);
            dtCategory.TabIndex = 1;
            dtCategory.CellClick += dtCategory_CellClick;
            dtCategory.CellContentClick += dtCategory_CellContentClick;
            // 
            // CategoryID
            // 
            CategoryID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CategoryID.DataPropertyName = "Category_ID";
            CategoryID.HeaderText = "Category ID";
            CategoryID.MinimumWidth = 8;
            CategoryID.Name = "CategoryID";
            CategoryID.ReadOnly = true;
            CategoryID.Width = 300;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CategoryName.DataPropertyName = "Category_Name";
            CategoryName.HeaderText = "Category Name";
            CategoryName.MinimumWidth = 8;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            CategoryName.Width = 400;
            // 
            // Edit
            // 
            Edit.HeaderText = "Update";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // CategoryPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 366);
            ControlBox = false;
            Controls.Add(dtCategory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryPanel";
            Activated += CategoryPanel_Activated;
            Load += CategoryPanel_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Category_datagridview;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView dtCategory;
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}