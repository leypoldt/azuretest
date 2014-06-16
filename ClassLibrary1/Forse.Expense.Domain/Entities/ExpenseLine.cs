using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forse.Expense.Domain.Entities
{
    public class ExpenseLine
    {
        public int Id { get; set; }
        public ExpenseItem Expense { get; set; }
        public ExpenseCategory Category { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
