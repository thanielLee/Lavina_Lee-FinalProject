using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavina_Lee_FinalProject
{
    public class Game
    {
        public String title;
        public int game_id;
        public string game_profile_path;
        public string genre;
        public int user_id;

        public Game(String title, int game_id, string game_profile_path, string genre, int user_id)
        {
            this.title = title;
            this.game_id = game_id;
            this.game_profile_path = game_profile_path;
            this.genre = genre;
            this.user_id = user_id;

        }
    }
}
