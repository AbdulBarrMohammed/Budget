using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        //public List<Transaction>? Transactions { get; set; }

    }
}
