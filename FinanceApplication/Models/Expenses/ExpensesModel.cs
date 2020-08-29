using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApplication.Models.Expenses;
using FinanceApplication.Models.Expenses.Subscriptions;
using FinanceApplication.Models.Expenses.Utilites;

namespace FinanceApplication.Models
{
    public class ExpensesModel
    {
        public WiFi WiFi { get; set; }
        public Food Food { get; set; }
        public Electricity Electricity { get; set; }
        public Fun Fun { get; set; }
        public Gas Gas { get; set; }
        public GymMembership GymMembership { get; set; }
        public Loans StudentLoans { get; set; }
        public Rent Rent { get; set; }
        public Phone PhoneBill { get; set; }
        public CarInsurance CarInsurance { get; set; }
        public CarPayment CarPayment { get; set; }
        public HuluSpotify HuluSpotify { get; set; }

        public ExpensesModel()
        {
            WiFi = new WiFi();
            Food = new Food();
            Electricity = new Electricity();
            Fun = new Fun();
            Gas = new Gas();
            GymMembership = new GymMembership();
            StudentLoans = new Loans();
            Rent = new Rent();
            PhoneBill = new Phone();
            CarInsurance = new CarInsurance();
            CarPayment = new CarPayment();
            HuluSpotify = new HuluSpotify();
        }

        public IEnumerable<Expense> GetEnumerator()
        {
            List<Expense> Expenses = new List<Expense>
            {
                WiFi,
                Food,
                Electricity,
                Fun,
                Gas,
                GymMembership,
                StudentLoans,
                Rent,
                PhoneBill,
                CarInsurance,
                CarPayment,
                HuluSpotify
            };

            return Expenses;

        }

    }
}
