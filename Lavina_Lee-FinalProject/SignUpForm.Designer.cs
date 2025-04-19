namespace Lavina_Lee_FinalProject
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SignUpButton = new Button();
            SignUpPasswordTextbox = new TextBox();
            SignUpPasswordLabel = new Label();
            SignUpUsernameLabel = new Label();
            SignUpUsernameTextbox = new TextBox();
            SignUpMessageBox = new Label();
            SignUpFormLoginButton = new Button();
            SignUpFormLoginLabel = new Label();
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(218, 67);
            SignUpButton.Margin = new Padding(3, 2, 3, 2);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(82, 22);
            SignUpButton.TabIndex = 9;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // SignUpPasswordTextbox
            // 
            SignUpPasswordTextbox.Location = new Point(190, 40);
            SignUpPasswordTextbox.Margin = new Padding(3, 2, 3, 2);
            SignUpPasswordTextbox.Name = "SignUpPasswordTextbox";
            SignUpPasswordTextbox.Size = new Size(110, 23);
            SignUpPasswordTextbox.TabIndex = 8;
            // 
            // SignUpPasswordLabel
            // 
            SignUpPasswordLabel.AutoSize = true;
            SignUpPasswordLabel.Location = new Point(120, 42);
            SignUpPasswordLabel.Name = "SignUpPasswordLabel";
            SignUpPasswordLabel.Size = new Size(57, 15);
            SignUpPasswordLabel.TabIndex = 7;
            SignUpPasswordLabel.Text = "Password";
            // 
            // SignUpUsernameLabel
            // 
            SignUpUsernameLabel.AutoSize = true;
            SignUpUsernameLabel.Location = new Point(120, 14);
            SignUpUsernameLabel.Name = "SignUpUsernameLabel";
            SignUpUsernameLabel.Size = new Size(60, 15);
            SignUpUsernameLabel.TabIndex = 6;
            SignUpUsernameLabel.Text = "Username";
            // 
            // SignUpUsernameTextbox
            // 
            SignUpUsernameTextbox.Location = new Point(191, 11);
            SignUpUsernameTextbox.Margin = new Padding(3, 2, 3, 2);
            SignUpUsernameTextbox.Name = "SignUpUsernameTextbox";
            SignUpUsernameTextbox.Size = new Size(110, 23);
            SignUpUsernameTextbox.TabIndex = 5;
            // 
            // SignUpMessageBox
            // 
            SignUpMessageBox.AutoSize = true;
            SignUpMessageBox.Location = new Point(12, 108);
            SignUpMessageBox.Name = "SignUpMessageBox";
            SignUpMessageBox.Size = new Size(60, 15);
            SignUpMessageBox.TabIndex = 10;
            SignUpMessageBox.Text = "Welcome!";
            // 
            // SignUpFormLoginButton
            // 
            SignUpFormLoginButton.Location = new Point(221, 189);
            SignUpFormLoginButton.Margin = new Padding(3, 2, 3, 2);
            SignUpFormLoginButton.Name = "SignUpFormLoginButton";
            SignUpFormLoginButton.Size = new Size(82, 22);
            SignUpFormLoginButton.TabIndex = 12;
            SignUpFormLoginButton.Text = " Login";
            SignUpFormLoginButton.UseVisualStyleBackColor = true;
            SignUpFormLoginButton.Click += SignUpFormLoginButton_Click;
            // 
            // SignUpFormLoginLabel
            // 
            SignUpFormLoginLabel.AutoSize = true;
            SignUpFormLoginLabel.Location = new Point(97, 192);
            SignUpFormLoginLabel.Name = "SignUpFormLoginLabel";
            SignUpFormLoginLabel.Size = new Size(118, 15);
            SignUpFormLoginLabel.TabIndex = 11;
            SignUpFormLoginLabel.Text = "Old user? Login here:";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 222);
            Controls.Add(SignUpFormLoginButton);
            Controls.Add(SignUpFormLoginLabel);
            Controls.Add(SignUpMessageBox);
            Controls.Add(SignUpButton);
            Controls.Add(SignUpPasswordTextbox);
            Controls.Add(SignUpPasswordLabel);
            Controls.Add(SignUpUsernameLabel);
            Controls.Add(SignUpUsernameTextbox);
            Name = "SignUpForm";
            Text = "Sign Up Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignUpButton;
        private TextBox SignUpPasswordTextbox;
        private Label SignUpPasswordLabel;
        private Label SignUpUsernameLabel;
        private TextBox SignUpUsernameTextbox;
        private Label SignUpMessageBox;
        private Button SignUpFormLoginButton;
        private Label SignUpFormLoginLabel;
    }
}