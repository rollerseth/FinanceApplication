using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApplication.Models.Expenses.Utilites;

namespace FinanceApplication.Models.Expenses
{
    public class FortCollinsBill
    {
        public Electricity ElectricityBill { get; set; }
        public Heat HeatBill { get; set; }

        
        public FortCollinsBill()
        {
            ElectricityBill = new Electricity();
            HeatBill = new Heat();
        }

    }
}
