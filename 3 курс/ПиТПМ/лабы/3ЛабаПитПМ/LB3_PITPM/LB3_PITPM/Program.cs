using System;
using System.Collections.Generic;

namespace UserAuthApp
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

        public string ShowAllUsers()
        {
            if (users.Count == 0)
                return "No users registered.";

            Console.WriteLine("\n--- Registered Users ---");
            foreach (var user in users)
            {
                Console.WriteLine($"Username: {user.Username}");
            }
            return "End of user list.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AuthService authService = new AuthService();
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Show All Users");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("\n--- Registration ---");
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();

                    // Output result of registration
                    Console.WriteLine(authService.Register(username, password));
                }
                else if (choice == "2")
                {
                    Console.WriteLine("\n--- Login ---");
                    Console.Write("Enter username: ");
                    string loginUsername = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string loginPassword = Console.ReadLine();

                    Console.WriteLine(authService.Login(loginUsername, loginPassword));
                }
                else if (choice == "3")
                {
                    Console.WriteLine(authService.ShowAllUsers());
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Exiting the application.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose 1, 2, 3, or 4.");
                }
            }
        }
    }
}
