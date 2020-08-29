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
        public GUARD PartTimeJob { get; set; }
        public DoorDash DoorDash { get; set; }

        public IncomeModel()
        {
            DayJob = new CreativeSystems();
            PartTimeJob = new GUARD();
            DoorDash = new DoorDash();
        }

    }
}
