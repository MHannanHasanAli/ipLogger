using ipLogger.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipLogger.Database
{
    public class ipLoggerContext : DbContext
    {
        public ipLoggerContext() { }
        public ipLoggerContext(DbContextOptions<ipLoggerContext> options) : base(options) { }

        public DbSet<ip> ips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=ipLogger-Database;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}