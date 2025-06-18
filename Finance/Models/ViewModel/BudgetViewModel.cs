using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Models
{
    public class BudgetViewModel
    {
        public List<Transaction>? Transactions { get; set; }
        public InsertTransactionViewModel InsertTransaction { get; set; }
    }
}
