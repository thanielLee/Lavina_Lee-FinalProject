using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavina_Lee_FinalProject
{
    public class User
    {
        String username;
        String password;
        public int user_id;
        public string profile_path;

        public User(String name, String pass, int user_id, string path)
        {
            username = name;
            password = pass;
            this.user_id = user_id;
            this.profile_path = path;
        }
    }
}
