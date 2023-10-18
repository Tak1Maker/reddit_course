/* 
 * Date: 02.12.2022
 * Author: salim 
 * Content: Create post page
 * 
 */

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
            if (tBoxContent.Text == "" || tBoxNameOfPost.Text == "")
                lblPostAdded.Text = "Please verify you filled the content and the title";
            else
            {
                lblPostAdded.Text = "Post added !";
                Home.AddToList(tBoxNameOfPost.Text, tBoxContent.Text, "salim");
            }
           
        }

        private void tBoxNameOfPost_TextChanged(object sender, EventArgs e)
        {

        }

        public void CreatePost_Load(object sender, EventArgs e)
        {

        }
    }
}
