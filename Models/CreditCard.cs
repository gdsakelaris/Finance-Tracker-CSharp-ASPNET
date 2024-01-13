using System.ComponentModel.DataAnnotations;

namespace FinanceTrackerWebApp.Models
{
    public class CreditCard
    {
        [Key]
        public int CardId { get; set; }

        [Display(Name = "Card Name")]
        public required string CustomCardName { get; set; }

        [Display(Name = "Current Balance")]
        public decimal CurrentBalance { get; set; }

        [Display(Name = "Credit Limit")]
        public decimal CreditLimit { get; set; }
    }
}
