using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApplication.Models.Expenses;

namespace FinanceApplication.Models
{
    public class ExpensesModel
    {
        public WiFi WiFi { get; set; }
        public Food Food { get; set; }
        public FortCollinsBill FortCollinsBill { get; set; }
        public Fun Fun { get; set; }
        public Gas Gas { get; set; }
        public GymMembership GymMembership { get; set; }
        public Loans StudentLoans { get; set; }
        public Rent Rent { get; set; }
        public Phone PhoneBill { get; set; }

        public ExpensesModel()
        {
            WiFi = new WiFi();
            Food = new Food();
            FortCollinsBill = new FortCollinsBill();
            Fun = new Fun();
            Gas = new Gas();
            GymMembership = new GymMembership();
            StudentLoans = new Loans();
            Rent = new Rent();
            PhoneBill = new Phone();
        }

    }
}
