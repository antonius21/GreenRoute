using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenRoute
{
    internal class User
    {
        public User(int id, string name, string login, string password)
        {
            Id = id;
            Name = name;
            Login = login;
            Password = password;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
