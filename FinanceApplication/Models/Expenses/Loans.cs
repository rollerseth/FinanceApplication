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
            Amount = 935;
            Description = "Monthly bill for Sallie Mae Student Loans";
            RecurringMonthly = true;
        }
    }
}
