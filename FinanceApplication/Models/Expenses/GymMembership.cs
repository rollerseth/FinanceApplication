using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses
{
    public class GymMembership : Expense
    {
        public GymMembership()
        {
            Amount = 100;
            Description = "Monthly bill for a gym membership";
            RecurringMonthly = true;
        }

    }
}
