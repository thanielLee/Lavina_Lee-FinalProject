namespace Lavina_Lee_FinalProject
{
    partial class AddGameForm
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
            GameTitleLabel = new Label();
            GameImagePathLabel = new Label();
            GameGenreLabel = new Label();
            GameTitleTextbox = new TextBox();
            GameImagePathTextbox = new TextBox();
            GameGenreTextbox = new TextBox();
            GameImagePathButton = new Button();
            AddGameButton = new Button();
            ImageWarningLabel = new Label();
            CloseFormButton = new Button();
            SuspendLayout();
            // 
            // GameTitleLabel
            // 
            GameTitleLabel.AutoSize = true;
            GameTitleLabel.Location = new Point(12, 9);
            GameTitleLabel.Name = "GameTitleLabel";
            GameTitleLabel.Size = new Size(66, 15);
            GameTitleLabel.TabIndex = 0;
            GameTitleLabel.Text = "Game Title:";
            // 
            // GameImagePathLabel
            // 
            GameImagePathLabel.AutoSize = true;
            GameImagePathLabel.Location = new Point(12, 38);
            GameImagePathLabel.Name = "GameImagePathLabel";
            GameImagePathLabel.Size = new Size(104, 15);
            GameImagePathLabel.TabIndex = 1;
            GameImagePathLabel.Text = "Game Image Path:";
            // 
            // GameGenreLabel
            // 
            GameGenreLabel.AutoSize = true;
            GameGenreLabel.Location = new Point(12, 67);
            GameGenreLabel.Name = "GameGenreLabel";
            GameGenreLabel.Size = new Size(75, 15);
            GameGenreLabel.TabIndex = 2;
            GameGenreLabel.Text = "Game Genre:";
            // 
            // GameTitleTextbox
            // 
            GameTitleTextbox.Location = new Point(122, 6);
            GameTitleTextbox.Name = "GameTitleTextbox";
            GameTitleTextbox.Size = new Size(100, 23);
            GameTitleTextbox.TabIndex = 3;
            // 
            // GameImagePathTextbox
            // 
            GameImagePathTextbox.Location = new Point(122, 35);
            GameImagePathTextbox.Name = "GameImagePathTextbox";
            GameImagePathTextbox.ReadOnly = true;
            GameImagePathTextbox.Size = new Size(100, 23);
            GameImagePathTextbox.TabIndex = 4;
            // 
            // GameGenreTextbox
            // 
            GameGenreTextbox.Location = new Point(122, 64);
            GameGenreTextbox.Name = "GameGenreTextbox";
            GameGenreTextbox.Size = new Size(100, 23);
            GameGenreTextbox.TabIndex = 5;
            // 
            // GameImagePathButton
            // 
            GameImagePathButton.Location = new Point(228, 35);
            GameImagePathButton.Name = "GameImagePathButton";
            GameImagePathButton.Size = new Size(75, 23);
            GameImagePathButton.TabIndex = 6;
            GameImagePathButton.Text = "Change";
            GameImagePathButton.UseVisualStyleBackColor = true;
            GameImagePathButton.Click += GameImagePathButton_Click;
            // 
            // AddGameButton
            // 
            AddGameButton.Location = new Point(244, 178);
            AddGameButton.Name = "AddGameButton";
            AddGameButton.Size = new Size(75, 23);
            AddGameButton.TabIndex = 7;
            AddGameButton.Text = "Add Game";
            AddGameButton.UseVisualStyleBackColor = true;
            AddGameButton.Click += AddGameButton_Click;
            // 
            // ImageWarningLabel
            // 
            ImageWarningLabel.AutoSize = true;
            ImageWarningLabel.Location = new Point(12, 160);
            ImageWarningLabel.Name = "ImageWarningLabel";
            ImageWarningLabel.Size = new Size(307, 15);
            ImageWarningLabel.TabIndex = 8;
            ImageWarningLabel.Text = "Leaving Game Image Path empty chooses default image.";
            // 
            // CloseFormButton
            // 
            CloseFormButton.Location = new Point(12, 178);
            CloseFormButton.Name = "CloseFormButton";
            CloseFormButton.Size = new Size(75, 23);
            CloseFormButton.TabIndex = 9;
            CloseFormButton.Text = "Close Form";
            CloseFormButton.UseVisualStyleBackColor = true;
            CloseFormButton.Click += CloseFormButton_Click;
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 213);
            Controls.Add(CloseFormButton);
            Controls.Add(ImageWarningLabel);
            Controls.Add(AddGameButton);
            Controls.Add(GameImagePathButton);
            Controls.Add(GameGenreTextbox);
            Controls.Add(GameImagePathTextbox);
            Controls.Add(GameTitleTextbox);
            Controls.Add(GameGenreLabel);
            Controls.Add(GameImagePathLabel);
            Controls.Add(GameTitleLabel);
            Name = "AddGameForm";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GameTitleLabel;
        private Label GameImagePathLabel;
        private Label GameGenreLabel;
        private TextBox GameTitleTextbox;
        private TextBox GameImagePathTextbox;
        private TextBox GameGenreTextbox;
        private Button GameImagePathButton;
        private Button AddGameButton;
        private Label ImageWarningLabel;
        private Button CloseFormButton;
    }
}