using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Zad2
{
    public class ExpenseTranstaction : Transactions
    {
        public override void ProcessTransaction()
        {
            Account.Expense -= Amount;
        }
    }
}
