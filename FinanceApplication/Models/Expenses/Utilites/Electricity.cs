using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses.Utilites
{
    public class Electricity : Expense
    {
        public Electricity()
        {
            Amount = 100;
            Description = "Monthly bill for the electric bill";
            RecurringMonthly = true;
        }
    }
}
