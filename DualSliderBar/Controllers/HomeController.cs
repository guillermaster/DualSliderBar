using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShortTermLoansModels;
using ShortTermLoansBusiness;

namespace DualSliderBar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Short Terms Loans Online";
            return View(GetViewModel());
        }
        
        public IActionResult Error()
        {
            return View();
        }

        private ShortTermLoanModel GetViewModel()
        {
            ShortTermLoanModel vm = new ShortTermLoanModel
            {
                MinCash = 50,
                MaxCash = 400,
                SelectedCash = 111,
                MinDays = 1,
                MaxDays = 35,
                Interest = Convert.ToDecimal(0.8),
                SelectedDays = 29
            };

            vm = ShortTermLoans.CalculateResult(vm);

            return vm;
        }

        [HttpGet]
        public ShortTermLoanModel CalculateResult(int cash, int days)
        {
            ShortTermLoanModel shortTermLoan = GetViewModel();
            shortTermLoan.SelectedCash = cash;
            shortTermLoan.SelectedDays = days;
            shortTermLoan = ShortTermLoans.CalculateResult(shortTermLoan);
            return shortTermLoan;
        }
    }
}
