using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerDS
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public string Currency { get; set; }

        public float AmountOthertoIndia { get; set; }

        public float AmountIndiatoOther { get; set; }

        public string Flag { get; set; }

        public DateTime Updated_Time { get; set; }
    }
}
