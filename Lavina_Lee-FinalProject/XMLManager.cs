using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lavina_Lee_FinalProject
{
    public struct UserStruct
    {
        public int user_id;
        public string profile_path;
    }

    public struct GameStruct
    {
        public int game_id;
        public string game_profile_path;
        public string genre;
        public int user_id;
    }

    public class XMLManager
    {
        public string base_dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public XmlDocument user_info;
        public XmlElement user_root;
        public int user_count;
        public string users_path;
        public string user_profile_path;

        public XmlDocument game_info;
        public XmlElement game_root;
        public int game_count;
        public string game_path;
        public string game_profile_path;

        public XmlDocument review_info;
        public XmlElement review_root;
        public int review_count;
        public string review_path;


        public XMLManager()
        {
            users_path = Path.Combine(base_dir, "users.xml");
            user_profile_path = Path.Combine(base_dir, "/pictures");

            user_info = new XmlDocument();

            if (File.Exists(users_path))
            {
                user_info.Load(users_path);
                user_root = user_info.DocumentElement;
                int.TryParse(user_root.GetAttribute("user_count"), out user_count);
            }
            else
            {
                XmlElement user_root_element = user_info.CreateElement("users");
                user_root = user_root_element;
                user_root.SetAttribute("user_count", "0");
                user_count = 0;

                user_info.AppendChild(user_root);

                user_info.Save(users_path);
            }


            game_path = Path.Combine(base_dir, "games.xml");
            user_profile_path = Path.Combine(base_dir, "/game_pictures");

            game_info = new XmlDocument();

            if (File.Exists(game_path))
            {
                game_info.Load(game_path);
                game_root = game_info.DocumentElement;
                int.TryParse(game_root.GetAttribute("game_count"), out game_count);
            }
            else
            {
                XmlElement game_root_element = game_info.CreateElement("games");
                game_root = game_root_element;
                game_root.SetAttribute("game_count", "0");
                game_count = 0;

                game_info.AppendChild(game_root);

                game_info.Save(game_path);
            }

            review_path = Path.Combine(base_dir, "reviews.xml");

            review_info = new XmlDocument();

            if (File.Exists(review_path))
            {
                review_info.Load(review_path);
                review_root = review_info.DocumentElement;
                int.TryParse(review_root.GetAttribute("review_count"), out review_count);
            }
            else
            {
                XmlElement review_root_element = review_info.CreateElement("reviews");
                review_root = review_root_element;
                review_root.SetAttribute("review_count", "0");
                review_count = 0;

                review_info.AppendChild(review_root);

                review_info.Save(review_path);
            }
        }

        public bool does_user_exist(string username)
        {
            foreach (XmlElement current_user in user_root.ChildNodes)
            {
                string cur_name = current_user.GetAttribute("username");

                if (cur_name == username)
                {
                    return true;
                }
            }

            // No username matched, return false
            return false;
        }

        public UserStruct verify_user(string username, string password)
        {
            UserStruct userStruct = new UserStruct();
            foreach (XmlElement current_user in user_root.ChildNodes)
            {
                string cur_name = current_user.GetAttribute("username");
                string cur_pass = current_user.GetAttribute("password");
                string profile_path = current_user.GetAttribute("profile_path");

                if (cur_name == username && cur_pass == password)
                {

                    string id_string = current_user.GetAttribute("user_id");
                    int user_id;
                    int.TryParse(id_string, out user_id);

                    // If username and password matched, return the user id and profile path

                    userStruct.user_id = user_id;
                    userStruct.profile_path = profile_path;
                    return userStruct;
                }
            }

            // No username and password matched, return -1 on user ID;
            userStruct.user_id = -1;
            return userStruct;
        }

        // Returns the id of the new user
        public UserStruct add_user(string username, string password)
        {
            XmlElement new_user = user_info.CreateElement("user");
            new_user.SetAttribute("username", username);
            new_user.SetAttribute("password", password);
            new_user.SetAttribute("user_id", user_count.ToString());
            new_user.SetAttribute("profile_path", "default.jpg");
            int user_id = user_count;

            UserStruct userStruct = new UserStruct();
            userStruct.user_id = user_id;
            userStruct.profile_path = "default.jpg";

            if (!does_user_exist(username))
            {
                user_root.AppendChild(new_user);
            }

            user_count++;
            user_root.SetAttribute("user_count", user_count.ToString());

            user_info.Save(users_path);
            return userStruct;
        }

        public void change_profile_path(string new_path, int user_id)
        {
            foreach (XmlElement current_user in user_root.ChildNodes)
            {
                int current_user_id;
                int.TryParse(current_user.GetAttribute("user_id"), out current_user_id);

                if (current_user_id == user_id)
                {
                    current_user.SetAttribute("profile_path", new_path);
                }

                user_info.Save(users_path);
            }
        }

        public GameStruct add_game(string game_title, string game_genre, int user_id)
        {
            XmlElement new_game = game_info.CreateElement("game");
            new_game.SetAttribute("game_title", game_title);
            new_game.SetAttribute("game_id", game_count.ToString());
            new_game.SetAttribute("game_profile_path", "default.jpg");
            new_game.SetAttribute("genre", game_genre);
            new_game.SetAttribute("user_id", user_id.ToString());

            int game_id = game_count;

            GameStruct gameStruct = new GameStruct();
            gameStruct.game_id = game_id;
            gameStruct.game_profile_path = "default.jpg";

            game_root.AppendChild(new_game);

            game_count++;
            game_root.SetAttribute("game_count", game_count.ToString());

            game_info.Save(game_path);
            return gameStruct;
        }

        public GameStruct add_game(string game_title, string game_genre, string game_profile_path, int user_id)
        {
            XmlElement new_game = game_info.CreateElement("game");
            new_game.SetAttribute("game_title", game_title);
            new_game.SetAttribute("game_id", game_count.ToString());
            new_game.SetAttribute("game_profile_path", game_profile_path);
            new_game.SetAttribute("genre", game_genre);
            new_game.SetAttribute("user_id", user_id.ToString());

            int game_id = game_count;

            GameStruct gameStruct = new GameStruct();
            gameStruct.game_id = game_id;
            gameStruct.game_profile_path = game_profile_path;
            gameStruct.genre = game_genre;
            gameStruct.user_id = user_id;

            game_root.AppendChild(new_game);

            game_count++;
            game_root.SetAttribute("game_count", game_count.ToString());

            game_info.Save(game_path);
            return gameStruct;
        }

        public void add_game(Game new_game)
        {
            XmlElement new_game_element = game_info.CreateElement("game");
            new_game_element.SetAttribute("game_title", new_game.title);
            new_game_element.SetAttribute("game_id", game_count.ToString());
            new_game_element.SetAttribute("game_profile_path", new_game.game_profile_path);
            new_game_element.SetAttribute("genre", new_game.genre);
            new_game_element.SetAttribute("user_id", new_game.user_id.ToString());

            int game_id = game_count;

            game_root.AppendChild(new_game_element);

            game_count++;
            game_root.SetAttribute("game_count", game_count.ToString());
            game_info.Save(game_path);
        }

        public List<Game> get_game_list()
        {
            List<Game> game_list = new List<Game>();

            foreach (XmlElement current_game in game_root.ChildNodes)
            {
                int game_id;
                int.TryParse(current_game.GetAttribute("game_id"), out game_id);

                string game_title = current_game.GetAttribute("game_title");
                string game_profile_path = current_game.GetAttribute("game_profile_path");
                string genre = current_game.GetAttribute("genre");

                int user_id;
                int.TryParse(current_game.GetAttribute("user_id"), out user_id);

                Game new_game = new Game(game_title, game_id, game_profile_path, genre, user_id);
                game_list.Add(new_game);
            }

            return game_list;
        }

        public void change_game_profile_path(string filepath, int game_id)
        {
            foreach (XmlElement current_game in game_root.ChildNodes)
            {
                int current_game_id;
                int.TryParse(current_game.GetAttribute("game_id"), out current_game_id);

                if (current_game_id == game_id)
                {
                    current_game.SetAttribute("game_profile_path", filepath);

                    game_info.Save(game_path);
                    break;
                }
            }
        }

        public void add_review(int user_id, int game_id, string review_description, float rating)
        {
            XmlElement new_review_element = review_info.CreateElement("review");
            new_review_element.SetAttribute("user_id", user_id.ToString());
            new_review_element.SetAttribute("game_id", game_id.ToString());
            new_review_element.SetAttribute("review_description", review_description);
            new_review_element.SetAttribute("rating", rating.ToString());
            new_review_element.SetAttribute("review_id", review_count.ToString());

            int review_id = review_count;

            review_root.AppendChild(new_review_element);

            review_count++;
            review_root.SetAttribute("review_count", review_count.ToString());
            review_info.Save(review_path);
        }

        public void delete_review(int review_id)
        {
            foreach (XmlElement current_review in review_root.ChildNodes)
            {
                int current_id;
                int.TryParse(current_review.GetAttribute("review_id"), out current_id);

                if (current_id == review_id)
                {
                    review_root.RemoveChild(current_review);
                    break;
                }
            }

            review_info.Save(review_path);
        }

        public List<Review> get_reviews_game(int game_id)
        {
            List<Review> reviews = new List<Review>();

            foreach (XmlElement current_review in review_root.ChildNodes)
            {
                int current_game_id = -1;
                int.TryParse(current_review.GetAttribute("game_id"), out current_game_id);



                if (current_game_id == game_id)
                {
                    int current_user_id = -1;
                    int.TryParse(current_review.GetAttribute("user_id"), out current_user_id);

                    int current_review_id = -1;
                    int.TryParse(current_review.GetAttribute("review_id"), out current_review_id);

                    float review_rating;
                    float.TryParse(current_review.GetAttribute("rating"), out review_rating);

                    string review_description = current_review.GetAttribute("review_description");
                    Review new_review = new Review(current_review_id, current_game_id, current_user_id, review_description, review_rating);
                    reviews.Add(new_review);
                }

            }

            return reviews;
        }

        public List<Review> get_reviews_user(int user_id)
        {
            List<Review> reviews = new List<Review>();

            foreach (XmlElement current_review in review_root.ChildNodes)
            {
                int current_user_id = -1;
                int.TryParse(current_review.GetAttribute("user_id"), out current_user_id);



                if (current_user_id == user_id)
                {
                    int current_game_id = -1;
                    int.TryParse(current_review.GetAttribute("game_id"), out current_game_id);

                    int current_review_id = -1;
                    int.TryParse(current_review.GetAttribute("review_id"), out current_review_id);

                    float review_rating;
                    float.TryParse(current_review.GetAttribute("rating"), out review_rating);

                    string review_description = current_review.GetAttribute("review_description");
                    Review new_review = new Review(current_review_id, current_game_id, current_user_id, review_description, review_rating);
                    reviews.Add(new_review);
                }

            }

            return reviews;
        }


        public string get_username(int user_id)
        {
            String username = "";

            foreach (XmlElement current_user in user_root.ChildNodes)
            {
                int current_user_id;
                int.TryParse(current_user.GetAttribute("user_id"), out current_user_id);

                if (current_user_id == user_id)
                {
                    username = current_user.GetAttribute("username");
                    break;
                }
            }

            return username;
        }
    }
}
