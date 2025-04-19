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
            SignUpButton = new Button();
            LoginMessageBox = new Label();
            SuspendLayout();
            // 
            // LoginUsernameTextbox
            // 
            LoginUsernameTextbox.Location = new Point(154, 15);
            LoginUsernameTextbox.Name = "LoginUsernameTextbox";
            LoginUsernameTextbox.Size = new Size(125, 27);
            LoginUsernameTextbox.TabIndex = 0;
            // 
            // LoginUsernameLabel
            // 
            LoginUsernameLabel.AutoSize = true;
            LoginUsernameLabel.Location = new Point(73, 18);
            LoginUsernameLabel.Name = "LoginUsernameLabel";
            LoginUsernameLabel.Size = new Size(75, 20);
            LoginUsernameLabel.TabIndex = 1;
            LoginUsernameLabel.Text = "Username";
            // 
            // LoginPasswordLabel
            // 
            LoginPasswordLabel.AutoSize = true;
            LoginPasswordLabel.Location = new Point(73, 56);
            LoginPasswordLabel.Name = "LoginPasswordLabel";
            LoginPasswordLabel.Size = new Size(70, 20);
            LoginPasswordLabel.TabIndex = 2;
            LoginPasswordLabel.Text = "Password";
            // 
            // LoginPasswordTextbox
            // 
            LoginPasswordTextbox.Location = new Point(154, 53);
            LoginPasswordTextbox.Name = "LoginPasswordTextbox";
            LoginPasswordTextbox.Size = new Size(125, 27);
            LoginPasswordTextbox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(185, 86);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginFormSignUpLabel
            // 
            LoginFormSignUpLabel.AutoSize = true;
            LoginFormSignUpLabel.Location = new Point(12, 233);
            LoginFormSignUpLabel.Name = "LoginFormSignUpLabel";
            LoginFormSignUpLabel.Size = new Size(167, 20);
            LoginFormSignUpLabel.TabIndex = 5;
            LoginFormSignUpLabel.Text = "New user? SIgn up here:";
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(185, 229);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(94, 29);
            SignUpButton.TabIndex = 6;
            SignUpButton.Text = "Signup";
            SignUpButton.UseVisualStyleBackColor = true;
            // 
            // LoginMessageBox
            // 
            LoginMessageBox.AutoSize = true;
            LoginMessageBox.Location = new Point(12, 139);
            LoginMessageBox.Name = "LoginMessageBox";
            LoginMessageBox.Size = new Size(75, 20);
            LoginMessageBox.TabIndex = 7;
            LoginMessageBox.Text = "Welcome!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 269);
            Controls.Add(LoginMessageBox);
            Controls.Add(SignUpButton);
            Controls.Add(LoginFormSignUpLabel);
            Controls.Add(LoginButton);
            Controls.Add(LoginPasswordTextbox);
            Controls.Add(LoginPasswordLabel);
            Controls.Add(LoginUsernameLabel);
            Controls.Add(LoginUsernameTextbox);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button SignUpButton;
        private Label LoginMessageBox;
    }
}
