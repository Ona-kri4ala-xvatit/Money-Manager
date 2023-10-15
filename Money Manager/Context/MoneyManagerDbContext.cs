using Microsoft.EntityFrameworkCore;
using Money_Manager.Models;

namespace Money_Manager.Context
{
    public class MoneyManagerDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        const string connectionString = $"Server=localhost\\SQLEXPRESS;Database=MoneyManagerDb;TrustServerCertificate=True;Trusted_Connection=True;";
        //const string connectionString = $"Server=localhost;Database=MoneyManagerDb;User Id=admin;Password=admin;TrustServerCertificate=True");

        public MoneyManagerDbContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
