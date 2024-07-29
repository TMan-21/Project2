using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2781_PROJECT
{
    public class BusinessLoan : Loan
    {
        public BusinessLoan(int loanNumber, string customerLastName, string customerFirstName, double loanAmount, int term) : base(loanNumber, customerLastName, customerFirstName, loanAmount, term)
        {
        }

        public BusinessLoan(int loanNumber, string customerLastName, string customerFirstName, double loanAmount, int term, double primeInterestRate,double LoanAmount) : base(loanNumber, customerLastName, customerFirstName, loanAmount, term)
        {
  
     
            LoanAmount = loanAmount + 500;  //500 for loan fee
            Dueamount = LoanAmount + LoanAmount * (InterestRate / 100) * term;
           Installments = (LoanAmount + loanAmount * (InterestRate / 100)) / (term * 12);
            InterestRate = primeInterestRate + 1; //primeIntrest is +1 in the BusinesLoan.
        }

        

        public override double GetAmountOwed()
        {
            throw new NotImplementedException();
        }

    }
}
