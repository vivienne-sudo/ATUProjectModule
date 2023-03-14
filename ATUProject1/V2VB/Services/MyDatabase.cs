using SQLite;
using System.Collections.Generic;
using System.Linq;
using V2VB.Model;

namespace V2VB.Services
{
    public class MyDatabase
    {
        private readonly SQLiteConnection _connection;

        public MyDatabase(string path)
        {
            _connection = new SQLiteConnection(path);
            _connection.CreateTable<User>();
        }

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
    }
}