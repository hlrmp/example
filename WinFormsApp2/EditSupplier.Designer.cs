namespace Meraki_POS_System
{
    partial class EditSupplier
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
            ContactNumTextBox = new TextBox();
            label3 = new Label();
            EmailTextBox = new TextBox();
            label5 = new Label();
            AddressTextbox = new TextBox();
            label2 = new Label();
            SupplierNameTextBox = new TextBox();
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
            CancelButton.Location = new Point(258, 275);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(152, 35);
            CancelButton.TabIndex = 23;
            CancelButton.Text = "Cancel";
            CancelButton.TextColor = Color.Red;
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
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
            UpdateButton.Location = new Point(62, 275);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(152, 35);
            UpdateButton.TabIndex = 22;
            UpdateButton.Text = "Update";
            UpdateButton.TextColor = Color.Black;
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // ContactNumTextBox
            // 
            ContactNumTextBox.BackColor = Color.White;
            ContactNumTextBox.Location = new Point(198, 206);
            ContactNumTextBox.Name = "ContactNumTextBox";
            ContactNumTextBox.Size = new Size(255, 31);
            ContactNumTextBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 210);
            label3.Name = "label3";
            label3.Size = new Size(171, 24);
            label3.TabIndex = 20;
            label3.Text = "Contact Number: ";
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.White;
            EmailTextBox.Location = new Point(198, 153);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(255, 31);
            EmailTextBox.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(22, 157);
            label5.Name = "label5";
            label5.Size = new Size(72, 24);
            label5.TabIndex = 18;
            label5.Text = "Email: ";
            // 
            // AddressTextbox
            // 
            AddressTextbox.BackColor = Color.White;
            AddressTextbox.Location = new Point(198, 100);
            AddressTextbox.Name = "AddressTextbox";
            AddressTextbox.Size = new Size(255, 31);
            AddressTextbox.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 104);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 16;
            label2.Text = "Address: ";
            // 
            // SupplierNameTextBox
            // 
            SupplierNameTextBox.BackColor = Color.White;
            SupplierNameTextBox.Location = new Point(198, 49);
            SupplierNameTextBox.Name = "SupplierNameTextBox";
            SupplierNameTextBox.Size = new Size(255, 31);
            SupplierNameTextBox.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 53);
            label1.Name = "label1";
            label1.Size = new Size(157, 24);
            label1.TabIndex = 14;
            label1.Text = "Supplier Name: ";
            // 
            // EditSupplier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(475, 359);
            Controls.Add(CancelButton);
            Controls.Add(UpdateButton);
            Controls.Add(ContactNumTextBox);
            Controls.Add(label3);
            Controls.Add(EmailTextBox);
            Controls.Add(label5);
            Controls.Add(AddressTextbox);
            Controls.Add(label2);
            Controls.Add(SupplierNameTextBox);
            Controls.Add(label1);
            Name = "EditSupplier";
            Text = "EditSupplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton CancelButton;
        private CustomButton UpdateButton;
        private TextBox ContactNumTextBox;
        private Label label3;
        private TextBox EmailTextBox;
        private Label label5;
        private TextBox AddressTextbox;
        private Label label2;
        private TextBox SupplierNameTextBox;
        private Label label1;
    }
}