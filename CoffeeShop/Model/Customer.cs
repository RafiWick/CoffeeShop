using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public double TotalSpent()
        {
            return Math.Round(Orders.Select(order => order.Total()).Sum(), 2);
        }

        public List<string> ItemsOrdered()
        {
            return Orders.SelectMany(order => order.Items).Select(item => item.Name).Distinct().ToList();
        }
    }
}
