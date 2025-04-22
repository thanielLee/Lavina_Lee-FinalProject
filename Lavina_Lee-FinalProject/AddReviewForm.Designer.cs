namespace Lavina_Lee_FinalProject
{
    partial class AddReviewForm
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
            GameRatingBaseLabel = new Label();
            GameReviewBaseLabel = new Label();
            RatingNumericUpDown = new NumericUpDown();
            GameTitleLabel = new Label();
            GameReviewTextbox = new TextBox();
            ExitFormButton = new Button();
            FinishReviewButton = new Button();
            MessageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)RatingNumericUpDown).BeginInit();
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
            // GameRatingBaseLabel
            // 
            GameRatingBaseLabel.AutoSize = true;
            GameRatingBaseLabel.Location = new Point(12, 34);
            GameRatingBaseLabel.Name = "GameRatingBaseLabel";
            GameRatingBaseLabel.Size = new Size(106, 15);
            GameRatingBaseLabel.TabIndex = 1;
            GameRatingBaseLabel.Text = "Game Rating (1-5):";
            // 
            // GameReviewBaseLabel
            // 
            GameReviewBaseLabel.AutoSize = true;
            GameReviewBaseLabel.Location = new Point(12, 68);
            GameReviewBaseLabel.Name = "GameReviewBaseLabel";
            GameReviewBaseLabel.Size = new Size(81, 15);
            GameReviewBaseLabel.TabIndex = 2;
            GameReviewBaseLabel.Text = "Game Review:";
            // 
            // RatingNumericUpDown
            // 
            RatingNumericUpDown.DecimalPlaces = 2;
            RatingNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            RatingNumericUpDown.Location = new Point(128, 32);
            RatingNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            RatingNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            RatingNumericUpDown.Name = "RatingNumericUpDown";
            RatingNumericUpDown.Size = new Size(50, 23);
            RatingNumericUpDown.TabIndex = 3;
            RatingNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // GameTitleLabel
            // 
            GameTitleLabel.AutoSize = true;
            GameTitleLabel.Location = new Point(128, 9);
            GameTitleLabel.Name = "GameTitleLabel";
            GameTitleLabel.Size = new Size(52, 15);
            GameTitleLabel.TabIndex = 4;
            GameTitleLabel.Text = "(default)";
            // 
            // GameReviewTextbox
            // 
            GameReviewTextbox.Location = new Point(128, 65);
            GameReviewTextbox.Multiline = true;
            GameReviewTextbox.Name = "GameReviewTextbox";
            GameReviewTextbox.Size = new Size(129, 130);
            GameReviewTextbox.TabIndex = 5;
            // 
            // ExitFormButton
            // 
            ExitFormButton.Location = new Point(12, 224);
            ExitFormButton.Name = "ExitFormButton";
            ExitFormButton.Size = new Size(75, 23);
            ExitFormButton.TabIndex = 6;
            ExitFormButton.Text = "Exit Form";
            ExitFormButton.UseVisualStyleBackColor = true;
            ExitFormButton.Click += ExitFormButton_Click;
            // 
            // FinishReviewButton
            // 
            FinishReviewButton.Location = new Point(93, 224);
            FinishReviewButton.Name = "FinishReviewButton";
            FinishReviewButton.Size = new Size(75, 23);
            FinishReviewButton.TabIndex = 7;
            FinishReviewButton.Text = "Finish";
            FinishReviewButton.UseVisualStyleBackColor = true;
            FinishReviewButton.Click += FinishReviewButton_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Location = new Point(174, 228);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(60, 15);
            MessageLabel.TabIndex = 8;
            MessageLabel.Text = "Welcome!";
            // 
            // AddReviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 259);
            Controls.Add(MessageLabel);
            Controls.Add(FinishReviewButton);
            Controls.Add(ExitFormButton);
            Controls.Add(GameReviewTextbox);
            Controls.Add(GameTitleLabel);
            Controls.Add(RatingNumericUpDown);
            Controls.Add(GameReviewBaseLabel);
            Controls.Add(GameRatingBaseLabel);
            Controls.Add(GameTitleBaseLabel);
            Name = "AddReviewForm";
            Text = "Add Review Form";
            ((System.ComponentModel.ISupportInitialize)RatingNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GameTitleBaseLabel;
        private Label GameRatingBaseLabel;
        private Label GameReviewBaseLabel;
        private NumericUpDown RatingNumericUpDown;
        private Label GameTitleLabel;
        private TextBox GameReviewTextbox;
        private Button ExitFormButton;
        private Button FinishReviewButton;
        private Label MessageLabel;
    }
}