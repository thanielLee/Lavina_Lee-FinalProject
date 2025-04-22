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
            SignUpButton.Location = new Point(249, 89);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(94, 29);
            SignUpButton.TabIndex = 9;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // SignUpPasswordTextbox
            // 
            SignUpPasswordTextbox.Location = new Point(217, 53);
            SignUpPasswordTextbox.Name = "SignUpPasswordTextbox";
            SignUpPasswordTextbox.Size = new Size(125, 27);
            SignUpPasswordTextbox.TabIndex = 8;
            // 
            // SignUpPasswordLabel
            // 
            SignUpPasswordLabel.AutoSize = true;
            SignUpPasswordLabel.Location = new Point(137, 56);
            SignUpPasswordLabel.Name = "SignUpPasswordLabel";
            SignUpPasswordLabel.Size = new Size(70, 20);
            SignUpPasswordLabel.TabIndex = 7;
            SignUpPasswordLabel.Text = "Password";
            // 
            // SignUpUsernameLabel
            // 
            SignUpUsernameLabel.AutoSize = true;
            SignUpUsernameLabel.Location = new Point(137, 19);
            SignUpUsernameLabel.Name = "SignUpUsernameLabel";
            SignUpUsernameLabel.Size = new Size(75, 20);
            SignUpUsernameLabel.TabIndex = 6;
            SignUpUsernameLabel.Text = "Username";
            // 
            // SignUpUsernameTextbox
            // 
            SignUpUsernameTextbox.Location = new Point(218, 15);
            SignUpUsernameTextbox.Name = "SignUpUsernameTextbox";
            SignUpUsernameTextbox.Size = new Size(125, 27);
            SignUpUsernameTextbox.TabIndex = 5;
            // 
            // SignUpMessageBox
            // 
            SignUpMessageBox.AutoSize = true;
            SignUpMessageBox.Location = new Point(14, 144);
            SignUpMessageBox.Name = "SignUpMessageBox";
            SignUpMessageBox.Size = new Size(75, 20);
            SignUpMessageBox.TabIndex = 10;
            SignUpMessageBox.Text = "Welcome!";
            // 
            // SignUpFormLoginButton
            // 
            SignUpFormLoginButton.Location = new Point(253, 252);
            SignUpFormLoginButton.Name = "SignUpFormLoginButton";
            SignUpFormLoginButton.Size = new Size(94, 29);
            SignUpFormLoginButton.TabIndex = 12;
            SignUpFormLoginButton.Text = " Login";
            SignUpFormLoginButton.UseVisualStyleBackColor = true;
            SignUpFormLoginButton.Click += SignUpFormLoginButton_Click;
            // 
            // SignUpFormLoginLabel
            // 
            SignUpFormLoginLabel.AutoSize = true;
            SignUpFormLoginLabel.Location = new Point(111, 256);
            SignUpFormLoginLabel.Name = "SignUpFormLoginLabel";
            SignUpFormLoginLabel.Size = new Size(148, 20);
            SignUpFormLoginLabel.TabIndex = 11;
            SignUpFormLoginLabel.Text = "Old user? Login here:";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 296);
            Controls.Add(SignUpFormLoginButton);
            Controls.Add(SignUpFormLoginLabel);
            Controls.Add(SignUpMessageBox);
            Controls.Add(SignUpButton);
            Controls.Add(SignUpPasswordTextbox);
            Controls.Add(SignUpPasswordLabel);
            Controls.Add(SignUpUsernameLabel);
            Controls.Add(SignUpUsernameTextbox);
            Margin = new Padding(3, 4, 3, 4);
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