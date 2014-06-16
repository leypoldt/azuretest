using Forse.Expense.Domain.Abstract;
using Forse.Expense.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forse.Expense.Domain.Concrete
{
    public class AzureStorageReceiptRepository : IReceiptRepository
    {
        public IQueryable<Receipt> Receipts
        {
            get { throw new NotImplementedException(); }
        }

        public void SaveReceipt(Receipt receipt)
        {
            throw new NotImplementedException();
        }

        public Receipt DeleteReceipt(int id)
        {
            throw new NotImplementedException();
        }
    }
}
