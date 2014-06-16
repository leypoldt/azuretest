using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forse.Expense.Domain.Entities
{
    public enum ExpenseState
    {
        DRAFT = 0,
        SUBMITTED = 1,
        APPROVED = 2,
        REJECTED = 3
    }

    public class ExpenseItem
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Owner { get; set; }
        public ExpenseState State { get; set; }
        public string RedjectMessage { get; set; }
        public bool IsFiled { get; set; }
    }
}
