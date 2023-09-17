using Microsoft.EntityFrameworkCore;
using System;

namespace HumanResoursesApplication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-9A9H02P\\SQLEXPRESS;Database=HumanResoursesdb;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<FullTimeEmployee> Fulltimeemployee { get; set; }
        public DbSet<PartTimeEmployee> Parttimeemployee { get; set; }
        public DbSet<TemporaryEmployee> Temporaryemployee { get; set; }
    }
}
