namespace Lavina_Lee_FinalProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginUsernameTextbox = new TextBox();
            LoginUsernameLabel = new Label();
            LoginPasswordLabel = new Label();
            LoginPasswordTextbox = new TextBox();
            LoginButton = new Button();
            LoginFormSignUpLabel = new Label();
            LoginFormSignUpButton = new Button();
            LoginMessageBox = new Label();
            SuspendLayout();
            // 
            // LoginUsernameTextbox
            // 
            LoginUsernameTextbox.Location = new Point(135, 11);
            LoginUsernameTextbox.Margin = new Padding(3, 2, 3, 2);
            LoginUsernameTextbox.Name = "LoginUsernameTextbox";
            LoginUsernameTextbox.Size = new Size(110, 23);
            LoginUsernameTextbox.TabIndex = 0;
            // 
            // LoginUsernameLabel
            // 
            LoginUsernameLabel.AutoSize = true;
            LoginUsernameLabel.Location = new Point(64, 14);
            LoginUsernameLabel.Name = "LoginUsernameLabel";
            LoginUsernameLabel.Size = new Size(60, 15);
            LoginUsernameLabel.TabIndex = 1;
            LoginUsernameLabel.Text = "Username";
            // 
            // LoginPasswordLabel
            // 
            LoginPasswordLabel.AutoSize = true;
            LoginPasswordLabel.Location = new Point(64, 42);
            LoginPasswordLabel.Name = "LoginPasswordLabel";
            LoginPasswordLabel.Size = new Size(57, 15);
            LoginPasswordLabel.TabIndex = 2;
            LoginPasswordLabel.Text = "Password";
            // 
            // LoginPasswordTextbox
            // 
            LoginPasswordTextbox.Location = new Point(135, 40);
            LoginPasswordTextbox.Margin = new Padding(3, 2, 3, 2);
            LoginPasswordTextbox.Name = "LoginPasswordTextbox";
            LoginPasswordTextbox.Size = new Size(110, 23);
            LoginPasswordTextbox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(162, 67);
            LoginButton.Margin = new Padding(3, 2, 3, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(82, 22);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginFormSignUpLabel
            // 
            LoginFormSignUpLabel.AutoSize = true;
            LoginFormSignUpLabel.Location = new Point(10, 175);
            LoginFormSignUpLabel.Name = "LoginFormSignUpLabel";
            LoginFormSignUpLabel.Size = new Size(133, 15);
            LoginFormSignUpLabel.TabIndex = 5;
            LoginFormSignUpLabel.Text = "New user? Sign up here:";
            // 
            // LoginFormSignUpButton
            // 
            LoginFormSignUpButton.Location = new Point(162, 172);
            LoginFormSignUpButton.Margin = new Padding(3, 2, 3, 2);
            LoginFormSignUpButton.Name = "LoginFormSignUpButton";
            LoginFormSignUpButton.Size = new Size(82, 22);
            LoginFormSignUpButton.TabIndex = 6;
            LoginFormSignUpButton.Text = "Signup";
            LoginFormSignUpButton.UseVisualStyleBackColor = true;
            LoginFormSignUpButton.Click += LoginFormSignUpButton_Click;
            // 
            // LoginMessageBox
            // 
            LoginMessageBox.AutoSize = true;
            LoginMessageBox.Location = new Point(10, 104);
            LoginMessageBox.Name = "LoginMessageBox";
            LoginMessageBox.Size = new Size(60, 15);
            LoginMessageBox.TabIndex = 7;
            LoginMessageBox.Text = "Welcome!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 202);
            Controls.Add(LoginMessageBox);
            Controls.Add(LoginFormSignUpButton);
            Controls.Add(LoginFormSignUpLabel);
            Controls.Add(LoginButton);
            Controls.Add(LoginPasswordTextbox);
            Controls.Add(LoginPasswordLabel);
            Controls.Add(LoginUsernameLabel);
            Controls.Add(LoginUsernameTextbox);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginUsernameTextbox;
        private Label LoginUsernameLabel;
        private Label LoginPasswordLabel;
        private TextBox LoginPasswordTextbox;
        private Button LoginButton;
        private Label LoginFormSignUpLabel;
        private Button LoginFormSignUpButton;
        private Label LoginMessageBox;
    }
}
