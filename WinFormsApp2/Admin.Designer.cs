namespace Meraki_POS_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel2 = new Panel();
            panel1 = new Panel();
            UserSet_button = new Button();
            SalesRep_button = new Button();
            Supplier_button = new Button();
            Inventory_button1 = new Button();
            ProductM_button = new Button();
            Dashboard_button = new Button();
            customPanel1 = new CustomPanel();
            label3 = new Label();
            logout_button = new Button();
            LogoutButton = new Button();
            User_set_Button = new Button();
            Store_Set_Button = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(1139, 474);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(UserSet_button);
            panel1.Controls.Add(SalesRep_button);
            panel1.Controls.Add(Supplier_button);
            panel1.Controls.Add(Inventory_button1);
            panel1.Controls.Add(ProductM_button);
            panel1.Controls.Add(Dashboard_button);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(customPanel1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-2, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 667);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // UserSet_button
            // 
            UserSet_button.FlatStyle = FlatStyle.Flat;
            UserSet_button.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            UserSet_button.Location = new Point(954, 101);
            UserSet_button.Name = "UserSet_button";
            UserSet_button.Size = new Size(176, 51);
            UserSet_button.TabIndex = 33;
            UserSet_button.Text = "User Settings";
            UserSet_button.UseVisualStyleBackColor = true;
            UserSet_button.Click += UserSet_button_Click_1;
            // 
            // SalesRep_button
            // 
            SalesRep_button.FlatStyle = FlatStyle.Flat;
            SalesRep_button.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SalesRep_button.Location = new Point(765, 101);
            SalesRep_button.Name = "SalesRep_button";
            SalesRep_button.Size = new Size(174, 51);
            SalesRep_button.TabIndex = 32;
            SalesRep_button.Text = "Sales Report";
            SalesRep_button.UseVisualStyleBackColor = true;
            SalesRep_button.Click += SalesRep_button_Click;
            // 
            // Supplier_button
            // 
            Supplier_button.FlatStyle = FlatStyle.Flat;
            Supplier_button.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Supplier_button.Location = new Point(623, 101);
            Supplier_button.Name = "Supplier_button";
            Supplier_button.Size = new Size(131, 51);
            Supplier_button.TabIndex = 31;
            Supplier_button.Text = "Supplier";
            Supplier_button.UseVisualStyleBackColor = true;
            Supplier_button.Click += Supplier_button_Click_1;
            // 
            // Inventory_button1
            // 
            Inventory_button1.FlatStyle = FlatStyle.Flat;
            Inventory_button1.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Inventory_button1.Location = new Point(473, 101);
            Inventory_button1.Name = "Inventory_button1";
            Inventory_button1.Size = new Size(141, 51);
            Inventory_button1.TabIndex = 30;
            Inventory_button1.Text = "Inventory";
            Inventory_button1.UseVisualStyleBackColor = true;
            Inventory_button1.Click += Inventory_button1_Click;
            // 
            // ProductM_button
            // 
            ProductM_button.FlatStyle = FlatStyle.Flat;
            ProductM_button.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ProductM_button.Location = new Point(198, 101);
            ProductM_button.Name = "ProductM_button";
            ProductM_button.Size = new Size(267, 51);
            ProductM_button.TabIndex = 29;
            ProductM_button.Text = "Product Management";
            ProductM_button.UseVisualStyleBackColor = true;
            ProductM_button.Click += ProductM_button_Click;
            // 
            // Dashboard_button
            // 
            Dashboard_button.FlatStyle = FlatStyle.Flat;
            Dashboard_button.Font = new Font("Copperplate Gothic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Dashboard_button.Location = new Point(30, 101);
            Dashboard_button.Name = "Dashboard_button";
            Dashboard_button.Size = new Size(149, 51);
            Dashboard_button.TabIndex = 28;
            Dashboard_button.Text = "Dashboard";
            Dashboard_button.UseVisualStyleBackColor = true;
            Dashboard_button.Click += Dashboard_button_Click_1;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Transparent;
            customPanel1.BackgroundImage = Properties.Resources.Screenshot_12;
            customPanel1.BorderRadius = 0;
            customPanel1.Controls.Add(label3);
            customPanel1.Controls.Add(logout_button);
            customPanel1.Controls.Add(LogoutButton);
            customPanel1.Controls.Add(User_set_Button);
            customPanel1.Controls.Add(Store_Set_Button);
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(label1);
            customPanel1.Controls.Add(pictureBox1);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 80F;
            customPanel1.GradientBottomColor = Color.DarkCyan;
            customPanel1.GradientTopColor = Color.SlateGray;
            customPanel1.Location = new Point(-2, 3);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1180, 82);
            customPanel1.TabIndex = 25;
            customPanel1.Paint += customPanel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(81, 40);
            label3.Name = "label3";
            label3.Size = new Size(115, 30);
            label3.TabIndex = 25;
            label3.Text = "ADMIN";
            // 
            // logout_button
            // 
            logout_button.FlatAppearance.BorderSize = 0;
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Image = Properties.Resources.icons8_logout_40;
            logout_button.Location = new Point(1078, 6);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(89, 71);
            logout_button.TabIndex = 24;
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logout_button_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.Transparent;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.ForeColor = Color.Black;
            LogoutButton.Image = Properties.Resources.icons8_log_out_30;
            LogoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutButton.Location = new Point(14, 591);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Padding = new Padding(15, 0, 0, 0);
            LogoutButton.Size = new Size(333, 34);
            LogoutButton.TabIndex = 23;
            LogoutButton.Text = "     LogOut";
            LogoutButton.TextAlign = ContentAlignment.MiddleLeft;
            LogoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutButton.UseVisualStyleBackColor = false;
            // 
            // User_set_Button
            // 
            User_set_Button.BackColor = Color.Transparent;
            User_set_Button.FlatAppearance.BorderSize = 0;
            User_set_Button.FlatStyle = FlatStyle.Flat;
            User_set_Button.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            User_set_Button.ForeColor = Color.Black;
            User_set_Button.Image = Properties.Resources.icons8_user_30;
            User_set_Button.ImageAlign = ContentAlignment.MiddleLeft;
            User_set_Button.Location = new Point(14, 551);
            User_set_Button.Name = "User_set_Button";
            User_set_Button.Padding = new Padding(15, 0, 0, 0);
            User_set_Button.Size = new Size(333, 34);
            User_set_Button.TabIndex = 22;
            User_set_Button.Text = "     User Setting";
            User_set_Button.TextAlign = ContentAlignment.MiddleLeft;
            User_set_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            User_set_Button.UseVisualStyleBackColor = false;
            // 
            // Store_Set_Button
            // 
            Store_Set_Button.BackColor = Color.Transparent;
            Store_Set_Button.FlatAppearance.BorderSize = 0;
            Store_Set_Button.FlatStyle = FlatStyle.Flat;
            Store_Set_Button.Font = new Font("Book Antiqua", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Store_Set_Button.ForeColor = Color.Black;
            Store_Set_Button.Image = Properties.Resources.icons8_store_setting_30;
            Store_Set_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Store_Set_Button.Location = new Point(14, 511);
            Store_Set_Button.Name = "Store_Set_Button";
            Store_Set_Button.Padding = new Padding(15, 0, 0, 0);
            Store_Set_Button.Size = new Size(333, 34);
            Store_Set_Button.TabIndex = 21;
            Store_Set_Button.Text = "     Store Setting";
            Store_Set_Button.TextAlign = ContentAlignment.MiddleLeft;
            Store_Set_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Store_Set_Button.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(102, 220);
            label2.Name = "label2";
            label2.Size = new Size(149, 26);
            label2.TabIndex = 15;
            label2.Text = "Administrator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 195);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 14;
            label1.Text = "User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(-6, 141);
            label5.Name = "label5";
            label5.Size = new Size(1184, 32);
            label5.TabIndex = 34;
            label5.Text = "_____________________________________________________________________________________________________________________";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 656);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Button LogoutButton;
        private Button User_set_Button;
        private Button Store_Set_Button;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private CustomPanel customPanel1;
        private Button UserSet_button;
        private Button SalesRep_button;
        private Button Supplier_button;
        private Button Inventory_button1;
        private Button ProductM_button;
        private Button Dashboard_button;
        private Button logout_button;
        private Label label3;
        private Label label5;
    }
}