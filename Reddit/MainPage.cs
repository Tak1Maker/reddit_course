/* 
 * Date: 02.12.2022
 * Author: salim 
 * Content: Main after login 
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

        public void btnExitTwo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            createPost1.Hide();
            userPage1.Hide();
            home1.Refresh();
            home1.Show();
        }

        public void MainPage_Load(object sender, EventArgs e)
        {
            userPage1.Hide();
            createPost1.Hide();
            home1.Show();
        }

        public void btnUserProfile_Click(object sender, EventArgs e)
        {
            createPost1.Hide();
            home1.Hide();
            userPage1.Show();
        }

        public void btnCreatePost_Click(object sender, EventArgs e)
        {
            home1.Hide();
            userPage1.Hide();
            createPost1.Show();
        }
    }
}
