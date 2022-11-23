using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TStore
{
    [Serializable]
    public class User
    {
        private string UserName;

        private double Balance;

        private List<Product> History;

        public User(string userName)
        {
            this.UserName = userName;
            Balance = 0;
            History = new();
        }

        public void ReplenishBalance(double amount)
        {
            Balance += amount;
        }

        public void Buy(Product product)
        {
            History.Add(product);
            Balance -= product.Price;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public string GetUserName()
        {
            return UserName;
        }

        public List<Product> GetHistory()
        {
            return new(History);
        }

    }
}
