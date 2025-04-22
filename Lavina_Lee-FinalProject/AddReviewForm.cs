using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavina_Lee_FinalProject
{
    public partial class AddReviewForm : Form
    {
        GameInfoForm gameForm;
        User cur_user; 
        Game cur_game;
        XMLManager xmlManager;
        public AddReviewForm(GameInfoForm gameForm, ref User cur_user, ref Game cur_game, ref XMLManager xmlManager)
        {
            InitializeComponent();
            this.gameForm = gameForm;
            this.cur_user = cur_user;
            this.cur_game = cur_game;
            this.xmlManager = xmlManager;
            GameTitleLabel.Text = cur_game.title;

        }

        private void ExitFormButton_Click(object sender, EventArgs e)
        {
            gameForm.Show();
            this.Close();
        }

        private void FinishReviewButton_Click(object sender, EventArgs e)
        {
            if (GameReviewTextbox.Text == "")
            {
                MessageLabel.Text = "Review is empty!";
                return;
            }

            var choose = MessageBox.Show(
                    "Finalize Review",
                    "Complete Review?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

            if (choose == DialogResult.Yes)
            {
                xmlManager.add_review(cur_user.user_id, cur_game.game_id, GameReviewTextbox.Text, (float)RatingNumericUpDown.Value);
                gameForm.Show();
                this.Close();
            }
            
        }
    }
}
