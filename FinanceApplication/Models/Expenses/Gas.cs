using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses
{
    public class Gas : Expense
    {
        public Gas()
        {
            Amount = 30;
            Description = "Monthly amount that is allocated for gas";
            RecurringMonthly = true;
        }
    }
}
