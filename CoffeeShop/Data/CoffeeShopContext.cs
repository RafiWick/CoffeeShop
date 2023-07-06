using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Data
{
    public class CoffeeShopContext : DbContext 
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=password123;Database=CoffeeShop";
            
            optionsBuilder.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
        }
    }
}
