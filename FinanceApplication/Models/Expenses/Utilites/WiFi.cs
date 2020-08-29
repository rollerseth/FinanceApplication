using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses
{
    public class WiFi : Expense
    {
        public WiFi()
        {
            Amount = 65;
            Description = "Monthly Cost of WiFi";
            RecurringMonthly = true;
        }

    }
}
