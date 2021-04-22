using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseCalculator.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expense")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public float Amount { get; set; }
    }
}
