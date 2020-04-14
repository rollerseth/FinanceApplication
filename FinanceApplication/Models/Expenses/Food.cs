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
            Amount = 300;
            Description = "Allocating $75 per week for groceries";
            RecurringMonthly = true;
        }
    }
}
