/* 
 * Date: 02.12.2022
 * Author: salim 
 * Content: Home page 
 * 
 */

namespace Reddit
{
    public partial class Home : UserControl
    {
        public static List<Post> Posts = new List<Post>();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void lblUserName1_Click(object sender, EventArgs e)
        {

        }
        public static void AddToList(string title, string content, string author)
        {
            var post = new Post(title, content, author);
            Posts.Add(post);
        }

        public void Home_Enter(object sender, EventArgs e)
        {
            var point = new Point(137, 20);
            foreach (var elem in Posts)
            {
                Label author = new Label();
                author.Text = elem.Author;
                author.Location = point;
                this.Controls.Add(author);

                Label title = new Label();
                title.Text = elem.Title;
                title.AutoSize = true;
                title.Location = new Point(point.X, point.Y + 20);
                this.Controls.Add(title);

                Label content = new Label();
                content.Text = elem.Content;
                content.Location = new Point(point.X, point.Y + 40);
                content.AutoSize = true;
                content.MaximumSize = ;
                this.Controls.Add(content);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
