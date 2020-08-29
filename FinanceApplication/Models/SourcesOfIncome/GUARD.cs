using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models.SourcesOfIncome
{
    public class GUARD : Income
    {

        public GUARD()
        {
            Amount = (25 * 15 * 4) * 0.85;
            Description = "My part-time job working as a Programmer I";
            Recurring = true;
        }
        
    }
}
