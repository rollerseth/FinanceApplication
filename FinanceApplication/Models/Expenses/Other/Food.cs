using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses
{
    public class Food : Expense
    {
        public Food()
        {
            Amount = 275;
            Description = "Allocated money for groceries per month";
            RecurringMonthly = true;
        }
    }
}
