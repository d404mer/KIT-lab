using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal class Program
        {
        // Строка подключения к базе данных (замените на вашу)
        private const string connectionString = "Server=DESKTOP-AF0FDGA;Database=DanilovaAA_4337;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в консольное приложение для управления базой данных!");

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Добавить запись");
                Console.WriteLine("5. Выход");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateRecord();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        break;
                }
            }
        }

        private static void CreateRecord()
        {
            Console.WriteLine("Введите имя студента:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст:");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Неверный формат возраста.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Students (Name, Age) VALUES (@Name, @Age)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Age", age);
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Запись добавлена.");
        }



    }

}