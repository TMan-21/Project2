using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2781_PROJECT
{
    public class PersonalLoan : Loan
    {
        public PersonalLoan(int loanNumber, string customerLastName, string customerFirstName, double loanAmount, int term) : base(loanNumber, customerLastName, customerFirstName, loanAmount, term)
        {
        }
        public override double GetAmountOwed()
        {
            throw new NotImplementedException();
        }
    }
}
