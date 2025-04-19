using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lavina_Lee_FinalProject
{
    public class XMLManager
    {
        public XmlDocument user_info;
        public XmlElement user_root;
        public int user_count;
        public string users_path;

        public XMLManager()
        {
            users_path = Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "users.xml");
            user_info = new XmlDocument();

            if (File.Exists(users_path))
            {
                user_info.Load(users_path);
                user_root = user_info.DocumentElement;
                int.TryParse(user_root.GetAttribute("user_count"), out user_count);
            } else
            {
                XmlElement user_root_element = user_info.CreateElement("users");
                user_root = user_root_element;
                user_root.SetAttribute("user_count", "0");
                user_count = 0;

                user_info.AppendChild(user_root);

                user_info.Save(users_path);
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

        public bool verify_user(string username, string password)
        {
            foreach (XmlElement current_user in user_root.ChildNodes)
            {
                string cur_name = current_user.GetAttribute("username");
                string cur_pass = current_user.GetAttribute("password");

                if (cur_name == username && cur_pass == password)
                {
                    return true;
                }
            }

            // No username and password matched, return false
            return false;
        }

        public void add_user(string username, string password)
        {
            XmlElement new_user = user_info.CreateElement("user");
            new_user.SetAttribute("username", username);
            new_user.SetAttribute("password", password);

            if (!does_user_exist(username))
            {
                user_root.AppendChild(new_user);
            }

            user_count++;
            user_root.SetAttribute("user_count", user_count.ToString());

            user_info.Save(users_path);
        }
    }
}
