namespace Meraki_POS_System
{
    partial class AddNewProduct
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
            CancelButton = new CustomButton();
            AddButton = new CustomButton();
            label3 = new Label();
            CategoryNameTextBox = new TextBox();
            ProductNameTextbox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.PaleTurquoise;
            CancelButton.BackgroundColor = Color.PaleTurquoise;
            CancelButton.BorderColor = Color.White;
            CancelButton.BorderRadius = 17;
            CancelButton.BorderSize = 0;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.Red;
            CancelButton.Location = new Point(262, 179);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(152, 35);
            CancelButton.TabIndex = 33;
            CancelButton.Text = "Cancel";
            CancelButton.TextColor = Color.Red;
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.PaleTurquoise;
            AddButton.BackgroundColor = Color.PaleTurquoise;
            AddButton.BorderColor = Color.White;
            AddButton.BorderRadius = 17;
            AddButton.BorderSize = 0;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.ForeColor = Color.Black;
            AddButton.Location = new Point(66, 179);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(152, 35);
            AddButton.TabIndex = 32;
            AddButton.Text = "Add";
            AddButton.TextColor = Color.Black;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 72);
            label3.Name = "label3";
            label3.Size = new Size(151, 24);
            label3.TabIndex = 30;
            label3.Text = "Product Name: ";
            // 
            // CategoryNameTextBox
            // 
            CategoryNameTextBox.BackColor = Color.White;
            CategoryNameTextBox.Location = new Point(204, 121);
            CategoryNameTextBox.Name = "CategoryNameTextBox";
            CategoryNameTextBox.Size = new Size(255, 31);
            CategoryNameTextBox.TabIndex = 29;
            // 
            // ProductNameTextbox
            // 
            ProductNameTextbox.BackColor = Color.White;
            ProductNameTextbox.Location = new Point(204, 68);
            ProductNameTextbox.Name = "ProductNameTextbox";
            ProductNameTextbox.Size = new Size(255, 31);
            ProductNameTextbox.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 125);
            label2.Name = "label2";
            label2.Size = new Size(162, 24);
            label2.TabIndex = 26;
            label2.Text = "Category Name: ";
            // 
            // AddNewProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(497, 283);
            Controls.Add(CancelButton);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(CategoryNameTextBox);
            Controls.Add(ProductNameTextbox);
            Controls.Add(label2);
            Name = "AddNewProduct";
            Text = "AddNewProduct";
            Load += AddNewProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton CancelButton;
        private CustomButton AddButton;
        private Label label3;
        private TextBox CategoryNameTextBox;
        private TextBox ProductNameTextbox;
        private Label label2;
    }
}