namespace Meraki_POS_System
{
    partial class EditProductList
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
            label3 = new Label();
            PriceTextBox = new TextBox();
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
            CancelButton.Location = new Point(270, 176);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(152, 35);
            CancelButton.TabIndex = 39;
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
            UpdateButton.Location = new Point(74, 176);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(152, 35);
            UpdateButton.TabIndex = 38;
            UpdateButton.Text = "Update";
            UpdateButton.TextColor = Color.Black;
            UpdateButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 69);
            label3.Name = "label3";
            label3.Size = new Size(151, 24);
            label3.TabIndex = 37;
            label3.Text = "Product Name: ";
            // 
            // PriceTextBox
            // 
            PriceTextBox.BackColor = Color.White;
            PriceTextBox.Location = new Point(212, 118);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(255, 31);
            PriceTextBox.TabIndex = 36;
            // 
            // ProductNameTextbox
            // 
            ProductNameTextbox.BackColor = Color.White;
            ProductNameTextbox.Location = new Point(212, 65);
            ProductNameTextbox.Name = "ProductNameTextbox";
            ProductNameTextbox.Size = new Size(255, 31);
            ProductNameTextbox.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 122);
            label2.Name = "label2";
            label2.Size = new Size(65, 24);
            label2.TabIndex = 34;
            label2.Text = "Price: ";
            // 
            // EditProductList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(506, 258);
            Controls.Add(CancelButton);
            Controls.Add(UpdateButton);
            Controls.Add(label3);
            Controls.Add(PriceTextBox);
            Controls.Add(ProductNameTextbox);
            Controls.Add(label2);
            Name = "EditProductList";
            Text = "EditProductList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton CancelButton;
        private CustomButton UpdateButton;
        private Label label3;
        private TextBox PriceTextBox;
        private TextBox ProductNameTextbox;
        private Label label2;
    }
}