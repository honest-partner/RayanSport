using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    class User
    {
       

        public String user_username { get; set; }
        public String user_password { get; set; }
        public String user_name { get; set; }
        public bool user_isAdmin { get; set; }
        public String user_gender { get; set; }
        public User(string user_username, string user_password, string user_name, bool user_isAdmin, string user_gender)
        {
            this.user_username = user_username;
            this.user_password = user_password;
            this.user_name = user_name;
            this.user_isAdmin = user_isAdmin;
            this.user_gender = user_gender;
        }
    }
}
