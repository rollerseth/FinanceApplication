using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses
{
    public class CarPayment : Expense
    {
        public CarPayment()
        {
            Amount = 300;
            Description = "Monthly car payment";
            RecurringMonthly = true;
        }
    }
}
