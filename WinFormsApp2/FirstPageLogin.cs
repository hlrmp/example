namespace Meraki_POS_System
{
    public partial class FirstPageLogin : Form
    {
        public FirstPageLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginAccount form2 = new LoginAccount();
            this.Hide();
            form2.Show();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to exit the system? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void FirstPageLogin_Load(object sender, EventArgs e)
        {








        }
    }
}