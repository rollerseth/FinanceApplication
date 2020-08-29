using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models
{
    public abstract class Income
    {
        public double NetAmount { get; set; }
        public double GrossAmount { get; set; }
        public string Description { get; set; }
        public bool Recurring { get; set; }

    }
}
