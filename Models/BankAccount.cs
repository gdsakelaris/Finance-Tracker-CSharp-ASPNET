using System.ComponentModel.DataAnnotations;

namespace FinanceTrackerWebApp.Models
{
    public class BankAccount
    {
        [Key]
        public int AccountId { get; set; }

        [Display(Name = "Account Name")]
        public required string CustomAccountName { get; set; }

        [Display(Name = "Account Type")]
        public required string AccountType { get; set; }

        [Display(Name = "Current Balance")]
        public decimal Balance { get; set; }
    }
}
