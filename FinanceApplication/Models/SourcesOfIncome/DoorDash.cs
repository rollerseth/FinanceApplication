
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.SourcesOfIncome
{
    public class DoorDash : Income
    {
        public DoorDash()
        {
            Amount = 200;
            Description = "Side job delivering food.";
            Recurring = true;
        }
    }
}
