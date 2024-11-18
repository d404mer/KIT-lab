using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    class Program
    {
        // Строка подключения к базе данных (замените на вашу)
        private const string connectionString = "Server=DESKTOP-AF0FDGA;Database=TestDB;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в консольное приложение для управления базой данных!");

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Добавить запись");
                Console.WriteLine("2. Прочитать записи");
                Console.WriteLine("3. Обновить запись");
                Console.WriteLine("4. Удалить запись");
                Console.WriteLine("5. Выход");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateRecord();
                        break;
                    case "2":
                        ReadRecords();
                        break;
                    case "3":
                        UpdateRecord();
                        break;
                    case "4":
                        DeleteRecord();
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
            Console.WriteLine("Введите имя сотрудника:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите должность:");
            string position = Console.ReadLine();

            Console.WriteLine("Введите зарплату:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal salary))
            {
                Console.WriteLine("Неверный формат зарплаты.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Employees (Name, Position, Salary) VALUES (@Name, @Position, @Salary)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Position", position);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Запись добавлена.");
        }

        private static void ReadRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Employees";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("\nСотрудники:");
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["Id"]}, Имя: {reader["Name"]}, Должность: {reader["Position"]}, Зарплата: {reader["Salary"]}");
                        }
                    }
                }
            }
        }

        private static void UpdateRecord()
        {
            Console.WriteLine("Введите ID записи, которую хотите обновить:");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Неверный ID.");
                return;
            }

            Console.WriteLine("Введите новое имя сотрудника:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите новую должность:");
            string position = Console.ReadLine();

            Console.WriteLine("Введите новую зарплату:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal salary))
            {
                Console.WriteLine("Неверный формат зарплаты.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Employees SET Name = @Name, Position = @Position, Salary = @Salary WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Position", position);
                    command.Parameters.AddWithValue("@Salary", salary);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Запись обновлена.");
                    }
                    else
                    {
                        Console.WriteLine("Запись с указанным ID не найдена.");
                    }
                }
            }
        }

        private static void DeleteRecord()
        {
            Console.WriteLine("Введите ID записи, которую хотите удалить:");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Неверный ID.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Employees WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Запись удалена.");
                    }
                    else
                    {
                        Console.WriteLine("Запись с указанным ID не найдена.");
                    }
                }
            }
        }
    }
    
}


