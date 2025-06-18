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
            //var categories = _context.Categories.Include(t => t.Transactions).ToList();
            //return View(categories);

            var transactions = _context.Transactions.ToList();
            var categories = _context.Categories.ToList();

            // Assign view model of transaction to pass to view model
            var viewModel = new BudgetViewModel
            {
                Transactions = transactions,
                InsertTransaction = new InsertTransactionViewModel { Categories = categories}
            };
            return View(viewModel);
        }

        public IActionResult InsertTransaction(BudgetViewModel model)
        {
            var transaction = new Transaction
            {
                Id = model.InsertTransaction.Id,
                Amount = model.InsertTransaction.Amount,
                Title = model.InsertTransaction.Title,
                Date = model.InsertTransaction.Date,
                CategoryId = model.InsertTransaction.CategoryId
            };

            _context.Add(transaction);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
