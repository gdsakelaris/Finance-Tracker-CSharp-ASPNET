using System.Diagnostics;
using FinanceTrackerWebApp.Data;
using FinanceTrackerWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FinanceTrackerWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new ViewModels.FinancialSummaryViewModel
            {
                TotalCreditCardDebt = _context.CreditCards.Sum(c => c.TotalBalance),
                TotalAvailableCredit = _context.CreditCards.Sum(c => c.CreditLimit - c.TotalBalance),
                TotalBankAccountBalance = _context.BankAccounts.Sum(b => b.Balance),
            };

            viewModel.NetWorth = viewModel.TotalBankAccountBalance - viewModel.TotalCreditCardDebt;

            return View(viewModel);
        }

            //public IActionResult Index()
            //{
            //    return View();
            //}

            public IActionResult Privacy()
            {
                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        
    }
}

