namespace Reddit
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxName_Click(object sender, EventArgs e)
        {
            tBoxName.BackColor = Color.White;
            pnlName.BackColor = Color.White;
            pnlPassword.BackColor = SystemColors.ControlLight;
            tBoxPassword.BackColor = SystemColors.ControlLight;

        }

        private void tBoxPassword_Click(object sender, EventArgs e)
        {
            pnlName.BackColor = SystemColors.ControlLight;
            pnlPassword.BackColor = Color.White;
            tBoxPassword.BackColor = Color.White;
            tBoxName.BackColor = SystemColors.ControlLight;
        }
    }
}