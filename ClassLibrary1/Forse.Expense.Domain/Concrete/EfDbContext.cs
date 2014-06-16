using Forse.Expense.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forse.Expense.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<ExpenseCategory> Categories { get; set; }
        public DbSet<ExpenseItem> Expenses { get; set; }
        public DbSet<ExpenseLine> ExpenseLines { get; set; }
    }
}
