using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Zad2
{
    public abstract class Transactions
    {
        public double Amount { get; set; }

        public DateTime TransactionDate { get; set; }
        public abstract void ProcessTransaction();
    }
}
