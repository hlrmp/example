namespace Meraki_POS_System
{
    partial class CreateAccUserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccUserSettings));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            passwrd_create_text = new TextBox();
            usernm_create_text = new TextBox();
            position_create_comboBox = new ComboBox();
            enter_create_button = new CustomButton();
            cancel_create_button = new CustomButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            name_create_text = new TextBox();
            label4 = new Label();
            contactnum_create_text = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(262, 88);
            label1.Name = "label1";
            label1.Size = new Size(120, 26);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(262, 135);
            label2.Name = "label2";
            label2.Size = new Size(108, 26);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(262, 178);
            label3.Name = "label3";
            label3.Size = new Size(108, 26);
            label3.TabIndex = 2;
            label3.Text = "Position";
            // 
            // passwrd_create_text
            // 
            passwrd_create_text.Location = new Point(472, 130);
            passwrd_create_text.Name = "passwrd_create_text";
            passwrd_create_text.Size = new Size(307, 31);
            passwrd_create_text.TabIndex = 6;
            // 
            // usernm_create_text
            // 
            usernm_create_text.Location = new Point(472, 88);
            usernm_create_text.Name = "usernm_create_text";
            usernm_create_text.Size = new Size(307, 31);
            usernm_create_text.TabIndex = 7;
            // 
            // position_create_comboBox
            // 
            position_create_comboBox.FormattingEnabled = true;
            position_create_comboBox.Location = new Point(472, 171);
            position_create_comboBox.Name = "position_create_comboBox";
            position_create_comboBox.Size = new Size(307, 33);
            position_create_comboBox.TabIndex = 10;
            position_create_comboBox.SelectedIndexChanged += position_create_comboBox_SelectedIndexChanged;
            // 
            // enter_create_button
            // 
            enter_create_button.BackColor = Color.CadetBlue;
            enter_create_button.BackgroundColor = Color.CadetBlue;
            enter_create_button.BorderColor = Color.Transparent;
            enter_create_button.BorderRadius = 18;
            enter_create_button.BorderSize = 0;
            enter_create_button.FlatAppearance.BorderColor = Color.White;
            enter_create_button.FlatAppearance.BorderSize = 2;
            enter_create_button.FlatStyle = FlatStyle.Flat;
            enter_create_button.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enter_create_button.ForeColor = Color.GhostWhite;
            enter_create_button.Location = new Point(472, 254);
            enter_create_button.Name = "enter_create_button";
            enter_create_button.Size = new Size(144, 46);
            enter_create_button.TabIndex = 11;
            enter_create_button.Text = "Save";
            enter_create_button.TextColor = Color.GhostWhite;
            enter_create_button.UseVisualStyleBackColor = false;
            enter_create_button.Click += enter_create_button_Click;
            // 
            // cancel_create_button
            // 
            cancel_create_button.BackColor = Color.CadetBlue;
            cancel_create_button.BackgroundColor = Color.CadetBlue;
            cancel_create_button.BorderColor = Color.PaleVioletRed;
            cancel_create_button.BorderRadius = 20;
            cancel_create_button.BorderSize = 0;
            cancel_create_button.FlatAppearance.BorderColor = Color.White;
            cancel_create_button.FlatAppearance.BorderSize = 2;
            cancel_create_button.FlatStyle = FlatStyle.Flat;
            cancel_create_button.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_create_button.ForeColor = Color.LightCyan;
            cancel_create_button.Location = new Point(642, 254);
            cancel_create_button.Name = "cancel_create_button";
            cancel_create_button.Size = new Size(137, 46);
            cancel_create_button.TabIndex = 12;
            cancel_create_button.Text = "Cancel";
            cancel_create_button.TextColor = Color.LightCyan;
            cancel_create_button.UseVisualStyleBackColor = false;
            cancel_create_button.Click += cancel_create_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_create_96;
            pictureBox1.Location = new Point(78, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(908, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // name_create_text
            // 
            name_create_text.Location = new Point(472, 43);
            name_create_text.Name = "name_create_text";
            name_create_text.Size = new Size(307, 31);
            name_create_text.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(262, 48);
            label4.Name = "label4";
            label4.Size = new Size(60, 26);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // contactnum_create_text
            // 
            contactnum_create_text.Location = new Point(472, 212);
            contactnum_create_text.Name = "contactnum_create_text";
            contactnum_create_text.Size = new Size(307, 31);
            contactnum_create_text.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(262, 217);
            label5.Name = "label5";
            label5.Size = new Size(180, 26);
            label5.TabIndex = 4;
            label5.Text = "Contact Number";
            // 
            // CreateAccUserSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1084, 341);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cancel_create_button);
            Controls.Add(enter_create_button);
            Controls.Add(position_create_comboBox);
            Controls.Add(contactnum_create_text);
            Controls.Add(usernm_create_text);
            Controls.Add(passwrd_create_text);
            Controls.Add(name_create_text);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAccUserSettings";
            Load += CreateAccUserSettings_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox passwrd_create_text;
        private TextBox usernm_create_text;
        private ComboBox position_create_comboBox;
        private CustomButton enter_create_button;
        private CustomButton cancel_create_button;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox name_create_text;
        private Label label4;
        private TextBox contactnum_create_text;
        private Label label5;
    }
}