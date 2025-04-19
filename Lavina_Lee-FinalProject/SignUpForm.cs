using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavina_Lee_FinalProject
{
    public partial class SignUpForm : Form
    {
        XMLManager xmlManager;
        public SignUpForm(ref XMLManager xmlManager)
        {
            this.xmlManager = xmlManager;
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string cur_name = SignUpUsernameTextbox.Text;
            string cur_pass = SignUpPasswordTextbox.Text;

            if (!xmlManager.does_user_exist(cur_name))
            {
                xmlManager.add_user(cur_name, cur_pass);
                User current_user = new User(cur_name, cur_pass);
                MainForm main_form = new MainForm(current_user);
                main_form.Show();
                this.Close();
            }
            else if (cur_name == "" || cur_pass == "")
            {
                SignUpMessageBox.Text = "Input field is empty!";
            }
            else
            {
                SignUpMessageBox.Text = "Username currently exists!";
            }
        }

        private void SignUpFormLoginButton_Click(object sender, EventArgs e)
        {
            LoginForm login_form = new LoginForm(ref xmlManager);
            login_form.Show();
            this.Close();
        }
    }
}
