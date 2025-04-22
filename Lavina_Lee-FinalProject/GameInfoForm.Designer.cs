namespace Lavina_Lee_FinalProject
{
    partial class GameInfoForm
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
            GameTitleBaseLabel = new Label();
            GameGenreBaseTitle = new Label();
            GameImageBaseTitle = new Label();
            GameTitleLabel = new Label();
            GameGenreLabel = new Label();
            GameImagePicturebox = new PictureBox();
            ReviewTableLayout = new TableLayoutPanel();
            ReviewAverageBaseLabel = new Label();
            ReviewAverageLabel = new Label();
            ExitFormButton = new Button();
            AddReviewButton = new Button();
            MessageLabel = new Label();
            UserLabel = new Label();
            RatingLabel = new Label();
            ReviewLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)GameImagePicturebox).BeginInit();
            SuspendLayout();
            // 
            // GameTitleBaseLabel
            // 
            GameTitleBaseLabel.AutoSize = true;
            GameTitleBaseLabel.Location = new Point(12, 9);
            GameTitleBaseLabel.Name = "GameTitleBaseLabel";
            GameTitleBaseLabel.Size = new Size(66, 15);
            GameTitleBaseLabel.TabIndex = 0;
            GameTitleBaseLabel.Text = "Game Title:";
            // 
            // GameGenreBaseTitle
            // 
            GameGenreBaseTitle.AutoSize = true;
            GameGenreBaseTitle.Location = new Point(12, 38);
            GameGenreBaseTitle.Name = "GameGenreBaseTitle";
            GameGenreBaseTitle.Size = new Size(75, 15);
            GameGenreBaseTitle.TabIndex = 1;
            GameGenreBaseTitle.Text = "Game Genre:";
            // 
            // GameImageBaseTitle
            // 
            GameImageBaseTitle.AutoSize = true;
            GameImageBaseTitle.Location = new Point(12, 68);
            GameImageBaseTitle.Name = "GameImageBaseTitle";
            GameImageBaseTitle.Size = new Size(77, 15);
            GameImageBaseTitle.TabIndex = 2;
            GameImageBaseTitle.Text = "Game Image:";
            // 
            // GameTitleLabel
            // 
            GameTitleLabel.AutoSize = true;
            GameTitleLabel.Location = new Point(106, 9);
            GameTitleLabel.Name = "GameTitleLabel";
            GameTitleLabel.Size = new Size(52, 15);
            GameTitleLabel.TabIndex = 3;
            GameTitleLabel.Text = "(default)";
            // 
            // GameGenreLabel
            // 
            GameGenreLabel.AutoSize = true;
            GameGenreLabel.Location = new Point(106, 38);
            GameGenreLabel.Name = "GameGenreLabel";
            GameGenreLabel.Size = new Size(52, 15);
            GameGenreLabel.TabIndex = 4;
            GameGenreLabel.Text = "(default)";
            // 
            // GameImagePicturebox
            // 
            GameImagePicturebox.Location = new Point(106, 68);
            GameImagePicturebox.Name = "GameImagePicturebox";
            GameImagePicturebox.Size = new Size(80, 80);
            GameImagePicturebox.SizeMode = PictureBoxSizeMode.Zoom;
            GameImagePicturebox.TabIndex = 5;
            GameImagePicturebox.TabStop = false;
            // 
            // ReviewTableLayout
            // 
            ReviewTableLayout.AutoScroll = true;
            ReviewTableLayout.ColumnCount = 3;
            ReviewTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            ReviewTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            ReviewTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            ReviewTableLayout.Location = new Point(230, 38);
            ReviewTableLayout.Name = "ReviewTableLayout";
            ReviewTableLayout.RowCount = 2;
            ReviewTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            ReviewTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            ReviewTableLayout.Size = new Size(505, 268);
            ReviewTableLayout.TabIndex = 6;
            ReviewTableLayout.VisibleChanged += ReviewTableLayout_VisibleChanged;
            ReviewTableLayout.Paint += ReviewTableLayout_Paint;
            // 
            // ReviewAverageBaseLabel
            // 
            ReviewAverageBaseLabel.AutoSize = true;
            ReviewAverageBaseLabel.Location = new Point(10, 172);
            ReviewAverageBaseLabel.Name = "ReviewAverageBaseLabel";
            ReviewAverageBaseLabel.Size = new Size(78, 15);
            ReviewAverageBaseLabel.TabIndex = 7;
            ReviewAverageBaseLabel.Text = "Game Rating:";
            // 
            // ReviewAverageLabel
            // 
            ReviewAverageLabel.AutoSize = true;
            ReviewAverageLabel.Location = new Point(106, 172);
            ReviewAverageLabel.Name = "ReviewAverageLabel";
            ReviewAverageLabel.Size = new Size(52, 15);
            ReviewAverageLabel.TabIndex = 8;
            ReviewAverageLabel.Text = "(default)";
            // 
            // ExitFormButton
            // 
            ExitFormButton.Location = new Point(12, 330);
            ExitFormButton.Name = "ExitFormButton";
            ExitFormButton.Size = new Size(75, 23);
            ExitFormButton.TabIndex = 9;
            ExitFormButton.Text = "Exit Form";
            ExitFormButton.UseVisualStyleBackColor = true;
            ExitFormButton.Click += ExitFormButton_Click;
            // 
            // AddReviewButton
            // 
            AddReviewButton.Location = new Point(99, 330);
            AddReviewButton.Name = "AddReviewButton";
            AddReviewButton.Size = new Size(87, 23);
            AddReviewButton.TabIndex = 10;
            AddReviewButton.Text = "Add Review";
            AddReviewButton.UseVisualStyleBackColor = true;
            AddReviewButton.Click += AddReviewButton_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Location = new Point(230, 334);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(60, 15);
            MessageLabel.TabIndex = 11;
            MessageLabel.Text = "Welcome!";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(230, 9);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(36, 15);
            UserLabel.TabIndex = 12;
            UserLabel.Text = " User:";
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(293, 9);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(44, 15);
            RatingLabel.TabIndex = 13;
            RatingLabel.Text = "Rating:";
            // 
            // ReviewLabel
            // 
            ReviewLabel.AutoSize = true;
            ReviewLabel.Location = new Point(364, 9);
            ReviewLabel.Name = "ReviewLabel";
            ReviewLabel.Size = new Size(47, 15);
            ReviewLabel.TabIndex = 14;
            ReviewLabel.Text = "Review:";
            // 
            // GameInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 365);
            Controls.Add(ReviewLabel);
            Controls.Add(RatingLabel);
            Controls.Add(UserLabel);
            Controls.Add(MessageLabel);
            Controls.Add(AddReviewButton);
            Controls.Add(ExitFormButton);
            Controls.Add(ReviewAverageLabel);
            Controls.Add(ReviewAverageBaseLabel);
            Controls.Add(ReviewTableLayout);
            Controls.Add(GameImagePicturebox);
            Controls.Add(GameGenreLabel);
            Controls.Add(GameTitleLabel);
            Controls.Add(GameImageBaseTitle);
            Controls.Add(GameGenreBaseTitle);
            Controls.Add(GameTitleBaseLabel);
            Name = "GameInfoForm";
            Text = "Game Information ";
            ((System.ComponentModel.ISupportInitialize)GameImagePicturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GameTitleBaseLabel;
        private Label GameGenreBaseTitle;
        private Label GameImageBaseTitle;
        private Label GameTitleLabel;
        private Label GameGenreLabel;
        private PictureBox GameImagePicturebox;
        private TableLayoutPanel ReviewTableLayout;
        private Label ReviewAverageBaseLabel;
        private Label ReviewAverageLabel;
        private Button ExitFormButton;
        private Button AddReviewButton;
        private Label MessageLabel;
        private Label UserLabel;
        private Label RatingLabel;
        private Label ReviewLabel;
    }
}