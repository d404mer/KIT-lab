using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksThingExams
{
    internal class Program
    {
        private const string connectionString = "Server=DESKTOP-AF0FDGA;Database=DanilovaAA_4337;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в консольное приложение для управления базой данных!");

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Добавить запись");
                Console.WriteLine("2. Выход");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateRecord();
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        break;
                }
            }
        }

        private static void CreateRecord()
        {
            Console.WriteLine("Введите название книги:");
            string title = Console.ReadLine();

            Console.WriteLine("Введите имя автора:");
            string author = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Books (Title, Author) VALUES (@Title, @Author)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Author", author);
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Запись добавлена.");
        }
    }
}
