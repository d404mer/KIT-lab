using BooksThingExams;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksThingExams
{
    public interface IEBooksRepository
    {
        void AddObject(string title, string author);
    }
}

public class BooksRepository : IEBooksRepository
{
    private readonly string _connectionString;

    public BooksRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void AddObject(string title, string author)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "INSERT INTO Students (Title, Author) VALUES (@Title, @Author)";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Author", author);
                command.ExecuteNonQuery();
            }
        }
    }


}


