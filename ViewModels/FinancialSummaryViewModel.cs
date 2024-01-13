namespace FinanceTrackerWebApp.ViewModels
{
    public class FinancialSummaryViewModel
    {
        public decimal TotalCreditCardDebt { get; set; }
        public decimal TotalAvailableCredit { get; set; }
        public decimal TotalBankAccountBalance { get; set; }
        public decimal NetWorth { get; set; }
    }
}
