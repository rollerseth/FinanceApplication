using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses.Utilites
{
    public class Heat : Expense
    {
        public Heat()
        {
            Amount = 50;
            Description = "Monthly bill for the heat";
            RecurringMonthly = true;
        }
    }
}
