using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses
{
    public class Rent : Expense
    {
        public Rent()
        {
            Amount = 1400;
            Description = "Monthly rent due";
            RecurringMonthly = true;
        }

    }
}
