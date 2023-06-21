namespace Meraki_POS_System
{
    partial class FirstPageLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPageLogin));
            LoginButton = new CustomButton();
            ExitButton = new CustomButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Transparent;
            LoginButton.BackgroundColor = Color.Transparent;
            LoginButton.BorderColor = Color.Transparent;
            LoginButton.BorderRadius = 18;
            LoginButton.BorderSize = 0;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.PaleTurquoise;
            LoginButton.Location = new Point(12, 587);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(144, 46);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Enter";
            LoginButton.TextColor = Color.PaleTurquoise;
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.BackgroundColor = Color.Transparent;
            ExitButton.BorderColor = Color.PaleVioletRed;
            ExitButton.BorderRadius = 20;
            ExitButton.BorderSize = 0;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.FromArgb(255, 128, 128);
            ExitButton.Location = new Point(461, 587);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(137, 46);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.TextColor = Color.FromArgb(255, 128, 128);
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(616, 617);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FirstPageLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImage = Properties.Resources.Screenshot_3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(610, 645);
            ControlBox = false;
            Controls.Add(ExitButton);
            Controls.Add(LoginButton);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FirstPageLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FirstPageLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CustomButton LoginButton;
        private CustomButton ExitButton;
        private PictureBox pictureBox1;
    }
}