namespace Reddit
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Label test = new Label();
            test.Name = "lblTest";
            test.Text = "testing";  
            test.Location = new Point(137, 88);
            this.Controls.Add(test);
        }

        private void lblUserName1_Click(object sender, EventArgs e)
        {

        }
    }
}
