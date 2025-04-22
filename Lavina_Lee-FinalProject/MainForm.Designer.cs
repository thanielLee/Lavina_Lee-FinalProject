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
            ((System.ComponentModel.ISupportInitialize)ProfilePicturebox).BeginInit();
            SuspendLayout();
            // 
            // ProfilePicturebox
            // 
            ProfilePicturebox.Location = new Point(822, 12);
            ProfilePicturebox.Name = "ProfilePicturebox";
            ProfilePicturebox.Size = new Size(80, 80);
            ProfilePicturebox.TabIndex = 0;
            ProfilePicturebox.TabStop = false;
            // 
            // ProfilePictureButton
            // 
            ProfilePictureButton.Location = new Point(822, 98);
            ProfilePictureButton.Name = "ProfilePictureButton";
            ProfilePictureButton.Size = new Size(80, 50);
            ProfilePictureButton.TabIndex = 1;
            ProfilePictureButton.Text = "Change Profile";
            ProfilePictureButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ProfilePictureButton);
            Controls.Add(ProfilePicturebox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)ProfilePicturebox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ProfilePicturebox;
        private Button ProfilePictureButton;
    }
}