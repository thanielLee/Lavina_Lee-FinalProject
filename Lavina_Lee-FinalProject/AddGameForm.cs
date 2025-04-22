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
    public partial class AddGameForm : Form
    {
        XMLManager xmlManager;
        MainForm mainForm;
        User current_user;
        List<Game> main_games;
        string filename = "default.jpg";
        public string destination_folder = Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "game_pictures/");
        public AddGameForm(ref XMLManager xmlManager, MainForm main_form, ref User current_user, ref List<Game> game_list)
        {
            this.main_games = game_list;
            this.xmlManager = xmlManager;
            this.mainForm = main_form;
            this.current_user = current_user;
            InitializeComponent();
        }

        private void GameImagePathButton_Click(object sender, EventArgs e)
        {
            string imageLocation;
            
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
                    filename = "game" + xmlManager.game_count.ToString() + file_ext;
                    string dest_filename = destination_folder + "/" + filename;
                    GameImagePathTextbox.Text = dest_filename;
                    File.Copy(imageLocation, dest_filename, true);
                }


            }
            catch (Exception ex)
            {

            }
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
           
            if (GameTitleTextbox.Text == "" || GameGenreTextbox.Text == "")
            {
                ImageWarningLabel.Text = "Input fields are incorrect!";
                return;
            }

            Game new_game = new Game(GameTitleTextbox.Text, xmlManager.game_count, filename, GameGenreTextbox.Text, current_user.user_id);
            xmlManager.add_game(new_game);
            main_games.Add(new_game);

            mainForm.Show();
            this.Close();

        }


    }
}
