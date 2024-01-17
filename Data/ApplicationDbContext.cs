using Microsoft.EntityFrameworkCore;
using FinanceTrackerWebApp.Models; // Replace with the actual namespace of your models

namespace FinanceTrackerWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>()
                .Property(b => b.Balance)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<CreditCard>()
                .Property(c => c.CreditLimit)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<CreditCard>()
                .Property(c => c.StatementBalance)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<CreditCard>()
                .Property(c => c.TotalBalance)
                .HasColumnType("decimal(18, 2)");
        }
    }
}
