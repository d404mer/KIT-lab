using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Laba12;

namespace login_system
{
    public class User
    {
        public long UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        //public string Departament { get; set; }
        public DepartamentClass Departament { get; set; }
        public string Title { get; set; }
 public int Salary { get; set; }
        public string Date { get; set; } // дата приёма на работу
        public string DateOfBirth { get; set; }
        public User() { }
        public User(string Login, string Password, string Name, string Surname,
       string Email, string Phone_number, string Departament, string Title, int Salary,
       string Date, string DateofBirth)
        {
            
            this.Login = Login;
            this.Password = Password;
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Phone_number = Phone_number;
            this.Departament = Departament;
            this.Title = Title;
            this.Salary = Salary;
            this.Date = Date;
            this.DateOfBirth = DateofBirth;
        }

    }
    public class UserContext : DbContext
    {
        public UserContext() : base("DbConnection")
        {
            //    Database.SetInitializer(new 
            //    CreateDatabaseIfNotExists<DbConnection>());
            //} DbConnection - имя будущей строки подключения к БД
        }
 public DbSet<User> Users { get; set; }
    }
}
