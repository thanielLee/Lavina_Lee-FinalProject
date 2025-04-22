using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lavina_Lee_FinalProject
{

    public partial class MainForm : Form
    {

        public string destination_folder = Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "pictures/");
        public string game_destination_folder = Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "game_pictures/");
        User current_user;
        XMLManager xmlManager;
        List<Game> existing_games;
        List<Review> reviews;
        List<Button> page_buttons;
        List<Button> remove_buttons;
        public MainForm(User current_user, ref XMLManager xmlManager)
        {
            page_buttons = new List<Button>();
            this.xmlManager = xmlManager;
            InitializeComponent();
            this.current_user = current_user;
            ProfilePicturebox.ImageLocation = Path.Combine(destination_folder, current_user.profile_path);
            existing_games = xmlManager.get_game_list();
            remove_buttons = new List<Button>();

            reviews = xmlManager.get_reviews_user(current_user.user_id);


            Debug.WriteLine(current_user.profile_path);
        }

        private void ProfilePictureButton_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All Files (*.*)|*.*";
                dialog.Title = "Select Profile Picture";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    string file_ext = "";
                    for (int i = dialog.FileName.Length - 1; i >= 0; i--)
                    {
                        file_ext = dialog.FileName[i] + file_ext;
                        if (dialog.FileName[i] == '.')
                        {
                            break;
                        }
                    }

                    if (!Directory.Exists(destination_folder))
                    {
                        Directory.CreateDirectory(destination_folder);
                    }

                    string dest_filename = destination_folder + "/user" + current_user.user_id.ToString() + file_ext;
                    File.Copy(imageLocation, dest_filename, true);


                    xmlManager.change_profile_path("user" + current_user.user_id.ToString() + file_ext, current_user.user_id);
                    ProfilePicturebox.ImageLocation = dest_filename;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


        }

        private void UserRatingLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            AddGameForm new_add_game = new AddGameForm(ref xmlManager, this, ref current_user, ref existing_games);

            this.Hide();
            new_add_game.Show();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void setupReviewTableLayout()
        {
            float total = 0;
            reviews = xmlManager.get_reviews_user(current_user.user_id);
            remove_buttons.Clear();
            Debug.WriteLine("Review Count:" + reviews.Count);


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

                Button delete_button = new Button();
                delete_button.Size = new Size(80, 20);
                delete_button.Text = "Delete Review!";
                delete_button.Anchor = AnchorStyles.None;
                delete_button.AutoSize = false;
                delete_button.Click += deleteButton_Pressed;
                delete_button.Name = i.ToString();

                ReviewTableLayout.Controls.Add(delete_button, 2, i);

                remove_buttons.Add(delete_button);

                Label description_label = new Label() { Text = reviews[i].review_description };

                ReviewTableLayout.Controls.Add(description_label, 3, i);
                description_label.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                description_label.TextAlign = ContentAlignment.MiddleCenter;
                description_label.AutoSize = true;


            }
        }

        private void deleteButton_Pressed(object sender, EventArgs e)
        {
            int review_index = -1;
            Button delete_button = (Button)sender;

            for (int i = 0; i < reviews.Count; i++)
            {
                if (delete_button == remove_buttons[i])
                {
                    review_index = i;
                    break;
                }
            }
            Debug.WriteLine("Current: " + review_index.ToString() + " Total: " + remove_buttons.Count);
            Review remove_review = reviews[review_index];
            xmlManager.delete_review(remove_review.review_id);
            setupReviewTableLayout();
        }

        private void setGameTableLayount()
        {
            page_buttons.Clear();



            while (GameTableLayout.Controls.Count > 0)
            {
                GameTableLayout.Controls[0].Dispose();
            }

            for (int i = 0; i < 4; i++)
            {
                Control cur = GameTableLayout.GetControlFromPosition(i, 0);
                if (cur != null)
                {
                    cur.Dispose();
                }
            }

            //GameTableLayout.Controls.Clear();
            GameTableLayout.RowCount = 1;

            for (int i = 0; i < existing_games.Count; i++)
            {
                Label title_label = new Label() { Text = existing_games[i].title };


                GameTableLayout.Controls.Add(title_label, 0, i);
                title_label.Anchor = AnchorStyles.None;
                title_label.AutoSize = false;
                title_label.TextAlign = ContentAlignment.MiddleCenter;



                if (i < existing_games.Count - 1)
                {
                    RowStyle prev_row_style = GameTableLayout.RowStyles[GameTableLayout.RowCount - 1];

                    GameTableLayout.RowCount++;

                    GameTableLayout.RowStyles.Add(new RowStyle(prev_row_style.SizeType, prev_row_style.Height));
                }

                Label genre_label = new Label() { Text = existing_games[i].genre };

                GameTableLayout.Controls.Add(genre_label, 1, i);
                genre_label.Anchor = AnchorStyles.None;
                genre_label.AutoSize = false;
                genre_label.TextAlign = ContentAlignment.MiddleCenter;

                PictureBox game_image = new PictureBox();
                game_image.Size = new Size(80, 80);
                game_image.SizeMode = PictureBoxSizeMode.Zoom;
                game_image.ImageLocation = Path.Combine(game_destination_folder, existing_games[i].game_profile_path);

                GameTableLayout.Controls.Add(game_image, 2, i);

                Button review_button = new Button();
                review_button.Size = new Size(80, 20);
                review_button.Text = "Add Review!";
                review_button.Anchor = AnchorStyles.None;
                review_button.AutoSize = false;
                review_button.Click += reviewButton_Pressed;
                review_button.Name = i.ToString();

                GameTableLayout.Controls.Add(review_button, 3, i);

                page_buttons.Add(review_button);

            }
        }

        private void reviewButton_Pressed(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Game cur_game = null;
            for (int i = 0; i < page_buttons.Count; i++) {
                if (page_buttons[i] == button)
                {
                    cur_game = existing_games[i];
                }
            }

            if (cur_game == null) return;
            GameInfoForm gameInfoForm = new GameInfoForm(ref xmlManager, this, ref cur_game, ref current_user);
            this.Hide();
            gameInfoForm.Show();
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false) return;



            setGameTableLayount();
            setupReviewTableLayout();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm new_login = new LoginForm(ref xmlManager);
            this.Close();
            new_login.Show();
        }

        private void ExitProgramButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                    "Exit Program?",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

            if (confirm == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void GameTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
