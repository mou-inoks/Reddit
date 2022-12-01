/* 
 * Author: Salim   
 * Date: 01.12.2022
 * 
 */

namespace Reddit
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnExitTwo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createPost1.Hide();
            userPage1.Hide();
            home1.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            userPage1.Hide();
            createPost1.Hide();
            home1.Show();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            createPost1.Hide();
            home1.Hide();
            userPage1.Show();
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            home1.Hide();
            userPage1.Hide();
            createPost1.Show();
        }
    }
}
