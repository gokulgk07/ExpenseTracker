using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerDS
{
    public class Category
    {
        public string CategoryName { get; set; }

        public int ID { get; set; }

        public string ImagePath { get; set; }

        public int ParentId { get; set; }

        public bool Type { get; set; }

        public List<int> WalletId { get; set; }
    }
}
