using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Db
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Data> Data { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=ConsoleApp;Trusted_Connection=true");
        }
    }
}
