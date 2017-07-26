using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DualSliderBar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Short Terms Loans Online";
            return View();
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
