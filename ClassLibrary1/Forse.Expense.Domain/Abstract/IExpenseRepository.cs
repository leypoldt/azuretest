using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forse.Expense.Domain.Entities;

namespace Forse.Expense.Domain.Abstract
{
    public interface IExpenseRepository
    {
        IQueryable<ExpenseItem> Expenses { get; }

        void SaveExpense(ExpenseItem expense);

        ExpenseItem DeleteExpense(int id);
    }
}
