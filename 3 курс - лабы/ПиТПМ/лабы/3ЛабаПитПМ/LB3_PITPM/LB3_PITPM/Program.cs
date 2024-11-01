using LB3_PITPM;
using System;
using System.Collections.Generic;
using UserAuthApp;

namespace UserAuthApp
{
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
                    Console.WriteLine("\n--- Registered Users ---");
                    var usernames = authService.GetAllUsernames();
                    if (usernames.Count == 0)
                    {
                        Console.WriteLine("No users registered.");
                    }
                    else
                    {
                        foreach (var username in usernames)
                        {
                            Console.WriteLine($"Username: {username}");
                        }
                    }
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
