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
    }
}
