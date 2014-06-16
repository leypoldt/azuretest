using Forse.Expense.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forse.Expense.Domain.Abstract
{
    public interface IReceiptRepository
    {
        IQueryable<Receipt> Receipts { get; }

        void SaveReceipt(Receipt receipt);

        Receipt DeleteReceipt(int id);
    }
}
