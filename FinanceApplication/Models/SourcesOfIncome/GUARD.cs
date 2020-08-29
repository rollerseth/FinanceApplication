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
            NetAmount = (25 * 14 * 4) * 0.85;
            GrossAmount = (25 * 14 * 4);
            Description = "My part-time job working as a Programmer I";
            Recurring = true;
        }
        
    }
}
