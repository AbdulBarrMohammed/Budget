using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Finance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Finance.Controllers
{
    //[Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly BudgetContext _context;

        public HomeController(BudgetContext context)
        {
           _context = context;
        }

        public IActionResult Index()
        {
            var transactions = _context.Transactions.Include(t => t.Category).ToList();
            return View(transactions);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
