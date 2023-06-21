namespace Meraki_POS_System
{
    partial class AddSupplier
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
            label1 = new Label();
            SupplierNameTextBox = new TextBox();
            AddressTextbox = new TextBox();
            label2 = new Label();
            EmailTextBox = new TextBox();
            label5 = new Label();
            ContactNumTextBox = new TextBox();
            label3 = new Label();
            SaveButton = new CustomButton();
            CancelButton = new CustomButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(157, 24);
            label1.TabIndex = 0;
            label1.Text = "Supplier Name: ";
            label1.Click += label1_Click;
            // 
            // SupplierNameTextBox
            // 
            SupplierNameTextBox.BackColor = Color.White;
            SupplierNameTextBox.Location = new Point(204, 28);
            SupplierNameTextBox.Name = "SupplierNameTextBox";
            SupplierNameTextBox.Size = new Size(255, 31);
            SupplierNameTextBox.TabIndex = 1;
            SupplierNameTextBox.TextChanged += SupplierNameTextBox_TextChanged;
            // 
            // AddressTextbox
            // 
            AddressTextbox.BackColor = Color.White;
            AddressTextbox.Location = new Point(204, 79);
            AddressTextbox.Name = "AddressTextbox";
            AddressTextbox.Size = new Size(255, 31);
            AddressTextbox.TabIndex = 3;
            AddressTextbox.TextChanged += AddressTextbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 83);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 2;
            label2.Text = "Address: ";
            label2.Click += label2_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.White;
            EmailTextBox.Location = new Point(204, 132);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(255, 31);
            EmailTextBox.TabIndex = 9;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 136);
            label5.Name = "label5";
            label5.Size = new Size(72, 24);
            label5.TabIndex = 8;
            label5.Text = "Email: ";
            label5.Click += label5_Click;
            // 
            // ContactNumTextBox
            // 
            ContactNumTextBox.BackColor = Color.White;
            ContactNumTextBox.Location = new Point(204, 185);
            ContactNumTextBox.Name = "ContactNumTextBox";
            ContactNumTextBox.Size = new Size(255, 31);
            ContactNumTextBox.TabIndex = 11;
            ContactNumTextBox.TextChanged += ContactNumTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 189);
            label3.Name = "label3";
            label3.Size = new Size(171, 24);
            label3.TabIndex = 10;
            label3.Text = "Contact Number: ";
            label3.Click += label3_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.PaleTurquoise;
            SaveButton.BackgroundColor = Color.PaleTurquoise;
            SaveButton.BorderColor = Color.White;
            SaveButton.BorderRadius = 17;
            SaveButton.BorderSize = 0;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.Black;
            SaveButton.Location = new Point(68, 254);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(152, 35);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Save";
            SaveButton.TextColor = Color.Black;
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
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
            CancelButton.Location = new Point(264, 254);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(152, 35);
            CancelButton.TabIndex = 13;
            CancelButton.Text = "Cancel";
            CancelButton.TextColor = Color.Red;
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(497, 317);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(ContactNumTextBox);
            Controls.Add(label3);
            Controls.Add(EmailTextBox);
            Controls.Add(label5);
            Controls.Add(AddressTextbox);
            Controls.Add(label2);
            Controls.Add(SupplierNameTextBox);
            Controls.Add(label1);
            Name = "AddSupplier";
            Text = "AddSupplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SupplierNameTextBox;
        private TextBox AddressTextbox;
        private Label label2;
        private TextBox EmailTextBox;
        private Label label5;
        private TextBox ContactNumTextBox;
        private Label label3;
        private CustomButton SaveButton;
        private CustomButton CancelButton;
    }
}