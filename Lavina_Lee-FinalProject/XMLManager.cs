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

                user_info.Save(users_path);
            }
        }

        public bool does_user_exist(string username, string password)
        {
            return true;
        }
    }
}
