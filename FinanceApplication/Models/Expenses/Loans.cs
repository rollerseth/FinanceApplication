using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses
{
    public class Loans : Expense
    {
        public Loans()
        {
            Amount = 700;
            Description = "Monthly bill for Student Loans";
            RecurringMonthly = true;
        }
    }
}
