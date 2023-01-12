using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class DbContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-JTHUOM0\\MSSQLSERVER1; Database=MY_PROJECT; Integrated Security=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerOperation> CustomerOperation { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<PriceList> PriceList { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<StocOperation> StocOperation { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<WareHouse> WareHouse { get; set; }
    }
}
