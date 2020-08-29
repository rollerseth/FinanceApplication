using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.Expenses.Subscriptions
{
    public class HuluSpotify : Expense
    {
        public HuluSpotify()
        {
            Amount = 10.59;
            Description = "Recurring charge for Hulu/Spotify";
            RecurringMonthly = true;
        }
    }
}
