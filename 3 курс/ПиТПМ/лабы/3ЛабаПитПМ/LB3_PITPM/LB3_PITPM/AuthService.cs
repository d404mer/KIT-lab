using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_PITPM
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

    public class AuthService
    {
        private List<User> users = new List<User>();

        public string Register(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return "Error: Username cannot be empty.";
            if (string.IsNullOrWhiteSpace(password))
                return "Error: Password cannot be empty.";

            if (users.Exists(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
                return "Error: Username already exists.";

            users.Add(new User(username, password));
            return "Registration successful!";
        }

        public string Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return "Error: Username cannot be empty.";
            if (string.IsNullOrWhiteSpace(password))
                return "Error: Password cannot be empty.";

            var user = users.Find(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password);
            return user != null ? "Login successful!" : "Error: Incorrect username or password.";
        }

        public List<string> GetAllUsernames()
        {
            var usernames = new List<string>();
            foreach (var user in users)
            {
                usernames.Add(user.Username);
            }
            return usernames;
        }
    }
}
