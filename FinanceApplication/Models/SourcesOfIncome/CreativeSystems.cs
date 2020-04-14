using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.SourcesOfIncome
{
    public class CreativeSystems : Income
    {
        public CreativeSystems()
        {
            Amount = (2666.67 * 2) * 0.75;
            Description = "My day job working as a SaaS Developer";
            Recurring = true;
        }
    }
}
