using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{
    public class Order
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; }

        public Order()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public double Total()
        {
            return Math.Round(Items.Select(item => item.PriceInDollars()).Sum(), 2);
        }
    }
}
