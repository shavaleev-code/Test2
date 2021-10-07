using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace Server.Models
{
    public class MyAppContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }

        public MyAppContext()
        {
            Database.EnsureCreated();            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=Cotkav83!;database=myapp;",
                new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}

