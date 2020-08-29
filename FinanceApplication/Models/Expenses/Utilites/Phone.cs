using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses
{
    public class Phone : Expense
    {
        public Phone()
        {
            Amount = 37.42;
            Description = "Monthly phone bill";
            RecurringMonthly = true;
        }

    }
}
