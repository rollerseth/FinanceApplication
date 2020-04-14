using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApplication.Models.SourcesOfIncome;

namespace FinanceApplication.Models
{
    public class IncomeModel
    {
        public CreativeSystems DayJob { get; set; }

        public IncomeModel()
        {
            DayJob = new CreativeSystems();
        }

    }
}
