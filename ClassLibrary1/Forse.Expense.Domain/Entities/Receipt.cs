using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forse.Expense.Domain.Entities
{
    public class Receipt
    {
        public int Id { get; set; }
        public ExpenseItem Expense { get; set; }
        public string ImageName { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}
