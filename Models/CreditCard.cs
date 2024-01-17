using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis;

namespace FinanceTrackerWebApp.Models
{
    public class CreditCard
    {
        [Key]
        public int CardId { get; set; }

        [Display(Name = "Card Name")]
        public required string CustomCardName { get; set; }

        [Display(Name = "Total Balance")]
        public decimal TotalBalance { get; set; }

        [Display(Name = "Statement")]
        public decimal StatementBalance { get; set; }

        [Display(Name = "Next Statement Due")]
        public DateTime NextPaymentDueDateTime { get; set; }

        [Display(Name = "Manage Card")]
        public string? CardManagementUrl { get; set; }

        [Display(Name = "Credit Limit")]
        public decimal CreditLimit { get; set; }
    }
}
