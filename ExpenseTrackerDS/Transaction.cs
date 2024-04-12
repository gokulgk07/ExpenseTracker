using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerDS
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public int CategoryId { get; set; }

        public String CategoryName { get; set; }

        public float Amount { get; set; }

        public DateTime Date { get; set; }

        public String Description { get; set; }

        public int WalletId { get; set; }
    }
}
