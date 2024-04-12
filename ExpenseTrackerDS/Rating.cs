using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerDS
{
    public class Rating
    {
        public int ID { get; set; }

        public int Account_Id { get; set; }

        public string Account_Name { get; set; }

        public float Rating_Value { get; set; }

        public bool Rated { get; set; }
    }
}
