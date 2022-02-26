using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=DESKTOP-JTHUOM0\\MSSQLSERVER1; Initial Catalog = MY_PROJECT; Integrated Security=True;");
        }

        public DbSet<User> Users { get; set; }
    }
}
