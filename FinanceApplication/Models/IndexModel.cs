using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApplication.Models
{
    public class IndexModel
    {
        public double ThisMonthsStartingAmount => 8451.96;

        public List<DateTime> MonthsAndYears { get; set; } = new List<DateTime>();
        public List<double> MonthlyStartingAmounts { get; set; } = new List<double>();
        public List<double> MonthlyEndingAmounts { get; set; } = new List<double>();
        public List<double> AmountLoansHaveBeenPaidOff { get; set; } = new List<double>();

        readonly ExpensesModel Expenses = new ExpensesModel();
        readonly IncomeModel Income = new IncomeModel();

        public IndexModel()
        {
            DateTime now = DateTime.Now;
            MonthlyStartingAmounts.Add(ThisMonthsStartingAmount);
            for (int i = 1; i <= 12; i++)
            {

                MonthlyEndingAmounts.Add(MonthlyStartingAmounts[i - 1] + TotalMonthlyIncome() - TotalMonthlyExpenses());         
                MonthsAndYears.Add(now.AddMonths(i));
                MonthlyStartingAmounts.Add(MonthlyEndingAmounts[i - 1]);
                AmountLoansHaveBeenPaidOff.Add(i * Expenses.StudentLoans.Amount);
            }
            
        }

        private double TotalMonthlyExpenses()
        {
            double total = 0;
            foreach(Expense expense in Expenses.GetEnumerator())
            {
                total += expense.Amount;
            }

            return total;
        }

        private double TotalMonthlyIncome()
        {
            double total = 0;
            foreach (Income income in Income.GetEnumerator())
            {
                total += income.Amount;
            }

            return total;
        }

    }
}
