namespace Reddit
{
    public partial class CreatePost : UserControl
    {
        public CreatePost()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        { 
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            lblPostAdded.Text = "Post succesfully added";
        }

        private void tBoxNameOfPost_TextChanged(object sender, EventArgs e)
        {

        }

        public void CreatePost_Load(object sender, EventArgs e)
        {

        }
    }
}
