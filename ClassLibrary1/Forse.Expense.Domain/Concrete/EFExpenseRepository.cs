using Forse.Expense.Domain.Abstract;
using Forse.Expense.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forse.Expense.Domain.Concrete
{
    public class EFExpenseRepository : IExpenseRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<ExpenseItem> Expenses
        {
            get
            {
                //something else
                return context.Expenses;
            }
        }

        public void SaveExpense(ExpenseItem expense)
        {
            if (expense.Id == 0)
            {
                // create new
                context.Expenses.Add(expense);
            }
            else
            {
                // edit existing
                ExpenseItem dbEntry = context.Expenses.Find(expense.Id);
                dbEntry.Title = expense.Title;
                dbEntry.Owner = expense.Owner;
                dbEntry.Date = expense.Date;
                dbEntry.State = expense.State;
                dbEntry.RedjectMessage = expense.RedjectMessage;
                dbEntry.IsFiled = expense.IsFiled;
            }
            context.SaveChanges();
        }

        public ExpenseItem DeleteExpense(int id)
        {
            ExpenseItem dbEntry = context.Expenses.Find(id);
            if (dbEntry != null)
            {
                context.Expenses.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
