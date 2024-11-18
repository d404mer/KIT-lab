using EmployeeManagementApp;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
namespace EmployeeManagementApp
{
    public interface IEmployeeRepository
    {
        void CreateEmployee(string name, string position, decimal salary);
        List<Employee> GetAllEmployees();
        void UpdateEmployee(int id, string name, string position, decimal salary);
        void DeleteEmployee(int id);
    }

}


public class EmployeeRepository : IEmployeeRepository
{
    private readonly string _connectionString;

    public EmployeeRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void CreateEmployee(string name, string position, decimal salary)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "INSERT INTO Employees (Name, Position, Salary) VALUES (@Name, @Position, @Salary)";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Position", position);
                command.Parameters.AddWithValue("@Salary", salary);
                command.ExecuteNonQuery();
            }
        }
    }

    public List<Employee> GetAllEmployees()
    {
        var employees = new List<Employee>();
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "SELECT * FROM Employees";
            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            Position = (string)reader["Position"],
                            Salary = (decimal)reader["Salary"]
                        });
                    }
                }
            }
        }
        return employees;
    }

    public void UpdateEmployee(int id, string name, string position, decimal salary)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "UPDATE Employees SET Name = @Name, Position = @Position, Salary = @Salary WHERE Id = @Id";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Position", position);
                command.Parameters.AddWithValue("@Salary", salary);
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteEmployee(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "DELETE FROM Employees WHERE Id = @Id";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}

