/* 
 * Date: 02.12.2022
 * Author: salim 
 * Content: login page
 * 
 */


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
            //onClick change both background 
            tBoxName.BackColor = Color.White;
            pnlName.BackColor = Color.White;
            pnlPassword.BackColor = SystemColors.ControlLight;
            tBoxPassword.BackColor = SystemColors.ControlLight;

        }

        private void tBoxPassword_Click(object sender, EventArgs e)
        {

            //onClick change both background 
            pnlName.BackColor = SystemColors.ControlLight;
            pnlPassword.BackColor = Color.White;
            tBoxPassword.BackColor = Color.White;
            tBoxName.BackColor = SystemColors.ControlLight;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tBoxName.Text == "salim" && tBoxPassword.Text == "1234")
            {
                lblPassword.Text = "Identifiants juste ! "; 
                MainPage page = new MainPage();
                page.Show();
            }
            else
            {
                lblPassword.Text = "Wrong password or User name, please try again";
            }
        }

        private void pnlLoggin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}