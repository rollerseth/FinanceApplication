using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses
{
    public class CarInsurance : Expense
    {
        public CarInsurance()
        {
            Amount = 670 / 6;
            Description = "Monthly car insurance payment";
            RecurringMonthly = true;
        }
    }
}
