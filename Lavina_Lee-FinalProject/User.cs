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
        int user_id;
        string profile_path;

        public User(String name, String pass, int user_id)
        {
            username = name;
            password = pass;
            this.user_id = user_id;
        }
    }
}
