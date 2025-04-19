namespace Lavina_Lee_FinalProject
{
    public partial class LoginForm : Form
    {
        XMLManager xmlManager;
        public LoginForm(ref XMLManager xmlManager)
        {
            this.xmlManager = xmlManager;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string cur_name = LoginUsernameTextbox.Text;
            string cur_pass = LoginPasswordTextbox.Text;

            if (xmlManager.verify_user(cur_name, cur_pass))
            {
                User current_user = new User(cur_name, cur_pass);
                MainForm main_form = new MainForm(current_user);
                main_form.Show();
                this.Close();
            }
            else if (cur_name == "" || cur_pass == "")
            {
                LoginMessageBox.Text = "Input field is empty!";
            }
            else
            {
                LoginMessageBox.Text = "Username or password is wrong!";
            }

        }

        private void LoginFormSignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signup_form = new SignUpForm(ref xmlManager);
            signup_form.Show();
            this.Close();
        }
    }
}
