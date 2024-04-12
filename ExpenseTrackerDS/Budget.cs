using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerDS
{
    public class Budget
    {
        public int BudgetId { get; set; }
        public int CategoryId { get; set; }
        public float Amount { get; set; }
        public Choices Choice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int WalletId { get; set; }

        public enum Choices
        {
            ThisWeek,
            ThisMonth,
            ThisQuarter,
            ThisYear,
            Custom
        }
    }
}
