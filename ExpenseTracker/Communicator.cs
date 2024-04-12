using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public static class Communicator
    {
        static Communicator()
        {
            Manager = new Manager();
        }

        public static Manager Manager { get; }
    }
}
