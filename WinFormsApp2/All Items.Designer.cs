namespace Meraki_POS_System
{
    partial class All_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(All_Items));
            flowLayoutPanel2 = new FlowLayoutPanel();
            button6 = new Button();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Location = new Point(115, 126);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(937, 415);
            flowLayoutPanel2.TabIndex = 38;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(210, 186);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            // 
            // All_Items
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg1;
            ClientSize = new Size(1167, 610);
            ControlBox = false;
            Controls.Add(flowLayoutPanel2);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.None;
            Name = "All_Items";
            Text = "All_Items";
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Button button6;
    }
}