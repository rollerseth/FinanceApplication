using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models
{
    public abstract class Expense
    {
        public double Amount { get; set; }
        public string Description { get; set; }
        public bool RecurringMonthly { get; set; }

    }
}
