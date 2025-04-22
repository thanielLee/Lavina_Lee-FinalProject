namespace Lavina_Lee_FinalProject
{
    partial class MainForm
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
            ProfilePicturebox = new PictureBox();
            ProfilePictureButton = new Button();
            GamesToReviewLabel = new Label();
            AddGameButton = new Button();
            UserRatingLabel = new Label();
            GameTableLayout = new TableLayoutPanel();
            LogoutButton = new Button();
            GameTitleLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ExitProgramButton = new Button();
            ReviewLabel = new Label();
            RatingLabel = new Label();
            UserLabel = new Label();
            ReviewTableLayout = new TableLayoutPanel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProfilePicturebox).BeginInit();
            SuspendLayout();
            // 
            // ProfilePicturebox
            // 
            ProfilePicturebox.Location = new Point(1200, 9);
            ProfilePicturebox.Margin = new Padding(3, 2, 3, 2);
            ProfilePicturebox.Name = "ProfilePicturebox";
            ProfilePicturebox.Size = new Size(70, 60);
            ProfilePicturebox.SizeMode = PictureBoxSizeMode.Zoom;
            ProfilePicturebox.TabIndex = 0;
            ProfilePicturebox.TabStop = false;
            // 
            // ProfilePictureButton
            // 
            ProfilePictureButton.Location = new Point(1200, 73);
            ProfilePictureButton.Margin = new Padding(3, 2, 3, 2);
            ProfilePictureButton.Name = "ProfilePictureButton";
            ProfilePictureButton.Size = new Size(70, 40);
            ProfilePictureButton.TabIndex = 1;
            ProfilePictureButton.Text = "Change Profile";
            ProfilePictureButton.UseVisualStyleBackColor = true;
            ProfilePictureButton.Click += ProfilePictureButton_Click;
            // 
            // GamesToReviewLabel
            // 
            GamesToReviewLabel.AutoSize = true;
            GamesToReviewLabel.Location = new Point(12, 9);
            GamesToReviewLabel.Name = "GamesToReviewLabel";
            GamesToReviewLabel.Size = new Size(100, 15);
            GamesToReviewLabel.TabIndex = 4;
            GamesToReviewLabel.Text = "Games to Review:";
            // 
            // AddGameButton
            // 
            AddGameButton.Location = new Point(1200, 118);
            AddGameButton.Name = "AddGameButton";
            AddGameButton.Size = new Size(70, 40);
            AddGameButton.TabIndex = 4;
            AddGameButton.Text = "Add Game";
            AddGameButton.UseVisualStyleBackColor = true;
            AddGameButton.Click += AddGameButton_Click;
            // 
            // UserRatingLabel
            // 
            UserRatingLabel.AutoSize = true;
            UserRatingLabel.Location = new Point(531, 21);
            UserRatingLabel.Name = "UserRatingLabel";
            UserRatingLabel.Size = new Size(76, 15);
            UserRatingLabel.TabIndex = 5;
            UserRatingLabel.Text = "Your reviews:";
            UserRatingLabel.Click += UserRatingLabel_Click;
            // 
            // GameTableLayout
            // 
            GameTableLayout.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            GameTableLayout.AutoScroll = true;
            GameTableLayout.ColumnCount = 4;
            GameTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            GameTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            GameTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            GameTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            GameTableLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            GameTableLayout.Location = new Point(12, 57);
            GameTableLayout.Name = "GameTableLayout";
            GameTableLayout.RowCount = 2;
            GameTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            GameTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            GameTableLayout.Size = new Size(336, 381);
            GameTableLayout.TabIndex = 6;
            GameTableLayout.Paint += GameTableLayout_Paint;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(1200, 164);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(70, 40);
            LogoutButton.TabIndex = 7;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // GameTitleLabel
            // 
            GameTitleLabel.AutoSize = true;
            GameTitleLabel.Location = new Point(185, 39);
            GameTitleLabel.Name = "GameTitleLabel";
            GameTitleLabel.Size = new Size(40, 15);
            GameTitleLabel.TabIndex = 8;
            GameTitleLabel.Text = "Image";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 39);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 8;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 39);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 39);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 10;
            label3.Text = "Review Button";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 39);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "Genre";
            // 
            // ExitProgramButton
            // 
            ExitProgramButton.Location = new Point(1200, 210);
            ExitProgramButton.Name = "ExitProgramButton";
            ExitProgramButton.Size = new Size(70, 40);
            ExitProgramButton.TabIndex = 11;
            ExitProgramButton.Text = "Exit Program";
            ExitProgramButton.UseVisualStyleBackColor = true;
            ExitProgramButton.Click += ExitProgramButton_Click;
            // 
            // ReviewLabel
            // 
            ReviewLabel.AutoSize = true;
            ReviewLabel.Location = new Point(755, 54);
            ReviewLabel.Name = "ReviewLabel";
            ReviewLabel.Size = new Size(47, 15);
            ReviewLabel.TabIndex = 18;
            ReviewLabel.Text = "Review:";
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(595, 54);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(44, 15);
            RatingLabel.TabIndex = 17;
            RatingLabel.Text = "Rating:";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(532, 54);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(36, 15);
            UserLabel.TabIndex = 16;
            UserLabel.Text = " User:";
            // 
            // ReviewTableLayout
            // 
            ReviewTableLayout.AutoScroll = true;
            ReviewTableLayout.ColumnCount = 4;
            ReviewTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            ReviewTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            ReviewTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            ReviewTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            ReviewTableLayout.Location = new Point(532, 83);
            ReviewTableLayout.Name = "ReviewTableLayout";
            ReviewTableLayout.RowCount = 2;
            ReviewTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            ReviewTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            ReviewTableLayout.Size = new Size(505, 268);
            ReviewTableLayout.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(660, 54);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 19;
            label5.Text = "Delete:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 450);
            Controls.Add(label5);
            Controls.Add(ReviewLabel);
            Controls.Add(RatingLabel);
            Controls.Add(UserLabel);
            Controls.Add(ReviewTableLayout);
            Controls.Add(ExitProgramButton);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GameTitleLabel);
            Controls.Add(LogoutButton);
            Controls.Add(GameTableLayout);
            Controls.Add(GamesToReviewLabel);
            Controls.Add(UserRatingLabel);
            Controls.Add(AddGameButton);
            Controls.Add(ProfilePictureButton);
            Controls.Add(ProfilePicturebox);
            Name = "MainForm";
            Text = "Main Form";
            Shown += MainForm_Shown;
            VisibleChanged += MainForm_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)ProfilePicturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProfilePicturebox;
        private Button ProfilePictureButton;
        private Panel GamesPanel;
        private Label GamesToReviewLabel;
        private Button AddGameButton;
        private Label UserRatingLabel;
        private Panel ReviewsPanel;
        private TableLayoutPanel GameTableLayout;
        private Button LogoutButton;
        private Label GameTitleLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ExitProgramButton;
        private Label ReviewLabel;
        private Label RatingLabel;
        private Label UserLabel;
        private TableLayoutPanel ReviewTableLayout;
        private Label label5;
    }
}