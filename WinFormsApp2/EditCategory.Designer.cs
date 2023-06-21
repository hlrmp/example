namespace Meraki_POS_System
{
    partial class EditCategory
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
            SaveButton = new CustomButton();
            EditCategoryNameTextBox = new TextBox();
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
            CancelButton.Location = new Point(260, 121);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(152, 35);
            CancelButton.TabIndex = 37;
            CancelButton.Text = "Cancel";
            CancelButton.TextColor = Color.Red;
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
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
            SaveButton.Location = new Point(64, 121);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(152, 35);
            SaveButton.TabIndex = 36;
            SaveButton.Text = "Save";
            SaveButton.TextColor = Color.Black;
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditCategoryNameTextBox
            // 
            EditCategoryNameTextBox.BackColor = Color.White;
            EditCategoryNameTextBox.Location = new Point(203, 56);
            EditCategoryNameTextBox.Name = "EditCategoryNameTextBox";
            EditCategoryNameTextBox.Size = new Size(255, 31);
            EditCategoryNameTextBox.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 60);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 34;
            label1.Text = "Category Name: ";
            // 
            // EditCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(485, 213);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(EditCategoryNameTextBox);
            Controls.Add(label1);
            Name = "EditCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditCategory";
            Load += EditCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton CancelButton;
        private CustomButton SaveButton;
        private TextBox EditCategoryNameTextBox;
        private Label label1;
    }
}