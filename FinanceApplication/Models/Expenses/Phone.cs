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
            Amount = 40;
            Description = "Monthly Phone Bill";
            RecurringMonthly = true;
        }

    }
}
