using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Finance.Models
{

     public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BudgetContext(
                serviceProvider.GetRequiredService<DbContextOptions<BudgetContext>>()))
            {
                // Look for any transactions.
                if (context.Transactions.Any())
                {
                    return;   // DB has been seeded
                }
                Category category = new Category
                {
                    Name = "Grocceries",
                };

                context.Categories.Add(category);
                context.SaveChanges();

                context.Transactions.AddRange(
                    new Transaction
                    {
                        Title = "Cereal",
                        Amount = 10.99m,
                        Date = DateTime.Parse("2025-2-12"),
                        CategoryId = category.Id,
                        Category = category
                    },
                    new Transaction
                    {
                        Title = "Apples",
                        Amount = 5.99m,
                        Date = DateTime.Parse("2025-2-12"),
                        CategoryId = category.Id,
                        Category = category
                    }

                );


                context.SaveChanges();
            }
        }
    }
}
