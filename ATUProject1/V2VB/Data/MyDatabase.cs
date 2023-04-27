using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V2VB.Model;

namespace V2VB.Data
{
    public class MyDatabase
    {
        private readonly SQLiteConnection _connection;

        public MyDatabase(string path)
        {
            _connection = new SQLiteConnection(path);
            _connection.CreateTable<User>();
            _connection.CreateTable<Company>();
            _connection.CreateTable<Employee>();
        }

        // User methods
        public List<User> GetUsers()
        {
            return _connection.Table<User>().ToList();
        }

        public User GetUser(int id)
        {
            return _connection.Table<User>().FirstOrDefault(x => x.Id == id);
        }

        public void SaveUser(User user)
        {
            if (user.Id == 0)
            {
                _connection.Insert(user);
            }
            else
            {
                _connection.Update(user);
            }
        }

        public void DeleteUser(User user)
        {
            _connection.Delete(user);
        }

        public User GetUserByEmail(string email)
        {
            return _connection.Table<User>().FirstOrDefault(x => x.Email == email);
        }

        public User GetUserByEmailAndPassword(string email, string passwordHash)
        {
            return _connection.Table<User>().FirstOrDefault(x => x.Email == email && x.PasswordHash == passwordHash);
        }

        // Company methods
        public List<Company> GetCompanies()
        {
            return _connection.Table<Company>().ToList();
        }

        public Company GetCompany(int id)
        {
            return _connection.Table<Company>().FirstOrDefault(x => x.Id == id);
        }

        public void SaveCompany(Company company)
        {
            if (company.Id == 0)
            {
                _connection.Insert(company);
            }
            else
            {
                _connection.Update(company);
            }
        }

        public void DeleteCompany(Company company)
        {
            _connection.Delete(company);
        }

        // Employee methods
        public List<Employee> GetEmployees()
        {
            return _connection.Table<Employee>().ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _connection.Table<Employee>().FirstOrDefault(x => x.Id == id);
        }

        public void SaveEmployee(Employee employee)
        {
            if (employee.Id == 0)
            {
                _connection.Insert(employee);
            }
            else
            {
                _connection.Update(employee);
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            _connection.Delete(employee);
        }
    }
}
