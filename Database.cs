using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TStore
{
    [Serializable]
    internal class Database 
    {
        private Dictionary<String, User> Users;

        private readonly List<Product> Products;

        public Database()
        {
            Users = new();
            Products = new()
            {
                new("Xiomi Powerbank", 10),
                new("IPhone 14", 1000),
                new("Wireless Charger", 20)
            };
        }

        public User GetUserIfExists(String username)
        {
            if (Users.ContainsKey(username))
                return Users[username];

            User user = new(username);
            Users.Add(username, user);

            return user;
        }

        public List<Product> GetProducts()
        {
            return new(Products);
        }
    }
}
