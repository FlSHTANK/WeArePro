using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Me_No._1
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
    public class Authentication
    {
        public List<User> users;

        public Authentication()
        {
           
            users = new List<User>();

            
            users.Add(new User("King", "123"));
            users.Add(new User("Queen", "321"));
            users.Add(new User("Jack", "101"));
        }
        public bool Login(string username, string password)
        {
           
            var user = users.FirstOrDefault(u => u.Username == username);

           
            if (user == null)
            {
                return false;
            }

           
            if (user.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
