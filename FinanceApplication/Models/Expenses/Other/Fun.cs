using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses
{
    public class Fun : Expense
    {
        public Fun()
        {
            Amount = 200;
            Description = "Monthly amount allocated for entertainment";
            RecurringMonthly = true;
        }

    }
}
