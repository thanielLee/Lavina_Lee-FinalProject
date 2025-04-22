namespace Lavina_Lee_FinalProject
{
    partial class TestForm
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
            TestPanel = new Panel();
            TestLabel1 = new Label();
            TestLabel2 = new Label();
            SuspendLayout();
            // 
            // TestPanel
            // 
            TestPanel.AutoScroll = true;
            TestPanel.Location = new Point(251, 120);
            TestPanel.Name = "TestPanel";
            TestPanel.Size = new Size(278, 158);
            TestPanel.TabIndex = 0;
            // 
            // TestLabel1
            // 
            TestLabel1.AutoSize = true;
            TestLabel1.Location = new Point(32, 14);
            TestLabel1.Name = "TestLabel1";
            TestLabel1.Size = new Size(87, 20);
            TestLabel1.TabIndex = 1;
            TestLabel1.Text = "Test Label 1";
            // 
            // TestLabel2
            // 
            TestLabel2.AutoSize = true;
            TestLabel2.Location = new Point(32, 53);
            TestLabel2.Name = "TestLabel2";
            TestLabel2.Size = new Size(87, 20);
            TestLabel2.TabIndex = 2;
            TestLabel2.Text = "Test Label 2";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TestLabel2);
            Controls.Add(TestLabel1);
            Controls.Add(TestPanel);
            Name = "TestForm";
            Text = "TestForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TestPanel;
        private Label TestLabel1;
        private Label TestLabel2;
    }
}