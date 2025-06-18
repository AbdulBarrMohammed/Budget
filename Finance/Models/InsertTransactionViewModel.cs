using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Models
{
    public class InsertTransactionViewModel
    {
        
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [DisplayName("Category")]
        public int CategoryId { get; set; }


        public List<Category>? Categories { get; set; }
    }
}
