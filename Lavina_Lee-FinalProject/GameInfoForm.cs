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
    public partial class GameInfoForm : Form
    {
        XMLManager xmlManager;
        MainForm mainForm;
        Game current_game;
        User current_user;
        List<Review> reviews;
        public string destination_folder = Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "game_pictures/");
        public GameInfoForm(ref XMLManager xmlManager, MainForm main_form, ref Game cur_game, ref User cur_user)
        {
            this.xmlManager = xmlManager;
            this.mainForm = main_form;
            this.current_game = cur_game;
            this.current_user = cur_user;






            InitializeComponent();

            reviews = xmlManager.get_reviews_game(cur_game.game_id);

            GameTitleLabel.Text = cur_game.title;
            GameGenreLabel.Text = cur_game.genre;
            GameImagePicturebox.ImageLocation = Path.Combine(destination_folder, cur_game.game_profile_path);
        
        }

        public void setupTableLayout()
        {
            float total = 0;
            reviews = xmlManager.get_reviews_game(current_game.game_id);

            if (reviews.Count == 0)
            {
                ReviewAverageLabel.Text = "No ratings yet!";
            }
            else
            {
                foreach (Review review in reviews)
                {
                    total += review.review_rating;
                }
                total /= (float)reviews.Count;
                ReviewAverageLabel.Text = total.ToString();
            }

            while (ReviewTableLayout.Controls.Count > 0)
            {
                ReviewTableLayout.Controls[0].Dispose();
            }

            for (int i = 0; i < 3; i++)
            {
                Control cur = ReviewTableLayout.GetControlFromPosition(i, 0);
                if (cur != null)
                {
                    cur.Dispose();
                }
            }

            //GameTableLayout.Controls.Clear();
            ReviewTableLayout.RowCount = 1;

            for (int i = 0; i < reviews.Count; i++)
            {
                if (i < reviews.Count - 1)
                {
                    RowStyle prev_row_style = ReviewTableLayout.RowStyles[ReviewTableLayout.RowCount - 1];

                    ReviewTableLayout.RowCount++;

                    ReviewTableLayout.RowStyles.Add(new RowStyle(prev_row_style.SizeType, prev_row_style.Height));
                }

                string review_username = xmlManager.get_username(reviews[i].user_id);
                Label username_label = new Label() { Text = review_username };

                ReviewTableLayout.Controls.Add(username_label, 0, i);
                username_label.Anchor = AnchorStyles.None;
                username_label.AutoSize = false;
                username_label.TextAlign = ContentAlignment.MiddleCenter;

                Label rating_label = new Label() { Text = reviews[i].review_rating.ToString() };

                ReviewTableLayout.Controls.Add(rating_label, 1, i);
                rating_label.Anchor = AnchorStyles.None;
                rating_label.AutoSize = false;
                rating_label.TextAlign = ContentAlignment.MiddleCenter;

                Label description_label = new Label() { Text = reviews[i].review_description };

                ReviewTableLayout.Controls.Add(description_label, 2, i);
                description_label.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                description_label.TextAlign = ContentAlignment.MiddleCenter;
                description_label.AutoSize = true;


            }
        }

        private void ExitFormButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void AddReviewButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            // If current user is the creator of the game, prevent review
            valid &= !(current_user.user_id == current_game.user_id);

            // If user already has a review on current game, prevent review

            foreach (Review review in reviews)
            {
                valid &= !(current_user.user_id == review.user_id);
            }

            if (!valid)
            {
                MessageLabel.Text = "Current user either already has a review or is the creator of the game, cannot publish a review!";
            }
            else
            {
                AddReviewForm addReviewForm = new AddReviewForm(this, ref current_user, ref current_game, ref xmlManager);
                this.Hide();
                addReviewForm.Show();
            }
        }

        private void ReviewTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReviewTableLayout_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible) return;

            setupTableLayout();
        }

        private void addReview(Review review)
        {
            reviews.Add(review);
        }
    }
}
