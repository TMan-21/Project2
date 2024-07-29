using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2781_PROJECT
{
    public abstract class Loan : LoanConstantsInterface
    {
        private int loanNumber;
        private string customerLastName;
        private string customerFirstName;
        private double loanAmount,dueamount, installments;
        private int term;
        private double interestRate;

        public int LoanNumber { get => loanNumber; set => loanNumber = value; }
        public string CustomerLastName { get => customerLastName; set => customerLastName = value; }
        public string CustomerFirstName { get => customerFirstName; set => customerFirstName = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public int Term { get => term; set => term = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }

        public Loan(int loanNumber, string customerLastName, string customerFirstName, double loanAmount, int term)
        {
            LoanNumber = loanNumber;
            CustomerLastName = customerLastName;
            CustomerFirstName = customerFirstName;
        }

       

        public abstract double GetAmountOwed();

        public int ShortTerm => 1;
        public int MediumTerm => 3;
        public int LongTerm => 5;
        public string CompanyName => "NedBank Finance";
        public int MaxLoanAmount => 100000;

        public double Dueamount { get => Dueamount; set => Dueamount = value; }
        public double Installments { get => installments; set => installments = value; }

        public override string ToString()
        {
            return $"Loan Number: {LoanNumber}\n" +
                   $"Customer: {CustomerFirstName} {CustomerLastName}\n" +
                   $"Loan Amount: {LoanAmount:C}\n" +
                   $"Interest Rate: {InterestRate}%\n" +
                   $"Term: {Term} years";
        }
    }
}
