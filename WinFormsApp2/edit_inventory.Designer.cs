namespace Meraki_POS_System
{
    partial class edit_inventory
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
            UpdateButton = new CustomButton();
            QuantityTextBox = new TextBox();
            label3 = new Label();
            PriceTextBox = new TextBox();
            label5 = new Label();
            CategoryTextbox = new TextBox();
            label2 = new Label();
            ProductNameTextBox = new TextBox();
            label1 = new Label();
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
            CancelButton.Location = new Point(270, 304);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(152, 35);
            CancelButton.TabIndex = 33;
            CancelButton.Text = "Cancel";
            CancelButton.TextColor = Color.Red;
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.PaleTurquoise;
            UpdateButton.BackgroundColor = Color.PaleTurquoise;
            UpdateButton.BorderColor = Color.White;
            UpdateButton.BorderRadius = 17;
            UpdateButton.BorderSize = 0;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.ForeColor = Color.Black;
            UpdateButton.Location = new Point(74, 304);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(152, 35);
            UpdateButton.TabIndex = 32;
            UpdateButton.Text = "Update";
            UpdateButton.TextColor = Color.Black;
            UpdateButton.UseVisualStyleBackColor = false;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.BackColor = Color.White;
            QuantityTextBox.Location = new Point(213, 229);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(255, 31);
            QuantityTextBox.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 233);
            label3.Name = "label3";
            label3.Size = new Size(101, 24);
            label3.TabIndex = 30;
            label3.Text = "Quantity: ";
            // 
            // PriceTextBox
            // 
            PriceTextBox.BackColor = Color.White;
            PriceTextBox.Location = new Point(213, 176);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(255, 31);
            PriceTextBox.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 180);
            label5.Name = "label5";
            label5.Size = new Size(65, 24);
            label5.TabIndex = 28;
            label5.Text = "Price: ";
            // 
            // CategoryTextbox
            // 
            CategoryTextbox.BackColor = Color.White;
            CategoryTextbox.Location = new Point(213, 123);
            CategoryTextbox.Name = "CategoryTextbox";
            CategoryTextbox.Size = new Size(255, 31);
            CategoryTextbox.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 127);
            label2.Name = "label2";
            label2.Size = new Size(162, 24);
            label2.TabIndex = 26;
            label2.Text = "Category Name: ";
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.BackColor = Color.White;
            ProductNameTextBox.Location = new Point(213, 72);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(255, 31);
            ProductNameTextBox.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 76);
            label1.Name = "label1";
            label1.Size = new Size(151, 24);
            label1.TabIndex = 24;
            label1.Text = "Product Name: ";
            // 
            // edit_inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(504, 405);
            Controls.Add(CancelButton);
            Controls.Add(UpdateButton);
            Controls.Add(QuantityTextBox);
            Controls.Add(label3);
            Controls.Add(PriceTextBox);
            Controls.Add(label5);
            Controls.Add(CategoryTextbox);
            Controls.Add(label2);
            Controls.Add(ProductNameTextBox);
            Controls.Add(label1);
            Name = "edit_inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton CancelButton;
        private CustomButton UpdateButton;
        private TextBox QuantityTextBox;
        private Label label3;
        private TextBox PriceTextBox;
        private Label label5;
        private TextBox CategoryTextbox;
        private Label label2;
        private TextBox ProductNameTextBox;
        private Label label1;
    }
}