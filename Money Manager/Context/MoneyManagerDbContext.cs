using Microsoft.EntityFrameworkCore;
using Money_Manager.Models;

namespace Money_Manager.Context
{
    public class MoneyManagerDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>().HasData(
                    new Account()
                    {
                        Id = 1,
                        AccountName = "Main",
                        Balance = 0,
                        Icon = "Wallet"
                    },
                    new Account()
                    {
                        Id = 2,
                        AccountName = "Second",
                        Balance = 0,
                        Icon = "Cash",
                    });
        }
    }
}
