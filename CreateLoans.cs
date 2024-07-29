using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRG2781_PROJECT
{
    class CreateLoans 
    {
        Loan[] loanarr = new Loan[5];
        int count = 0;
        
        double pInterestRate = 12.5;
        public CreateLoans()
        {
        }

        enum loanmenuCategory
        {
            business = 1,
            personal     
        }

        enum promptfinish
        {
            
        }


        public void loan()
        {
            Console.Clear();
            

        repeat:
            
           goto repeat;
        }

        public void getpIntRate()
        {
            Console.Clear() ;
            Console.WriteLine("Welcome to Unique Building Solutions." +
                "\nOur current standard Interest rate is 12.5%\n");
            //Console.WriteLine("Enter interest Rate");
            //pInterestRate = float.Parse(Console.ReadLine());
            Thread.Sleep(1500);
            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine("====================================\n");
                Console.WriteLine($"Enter details for customer {i}");
                Console.Write($"Enter customer FirstName: ");
                string customerFirstName  = Console.ReadLine();
                Console.Write($"Enter customer LastName: ");
                string customerLastName = Console.ReadLine();
                repeat:
                Console.Write($"Enter Loan Amount: ");
                float loanAmount = float.Parse(Console.ReadLine());
                if(loanAmount > 100000)
                {
                    Console.WriteLine("Re-enter a valid loan amount in the correct range");
                    goto repeat;
                }              

                Console.WriteLine($"Enter loan term (1 for short-term, 3 for medium-term, 5 for long-term):\n" +
                    $"If uncertain default is (short-term)");
                int Term = int.Parse( Console.ReadLine());
                if (Term == 1 || Term == 3 || Term == 5)
                {
                   Term = Term;
                }
                else { Term = 1; }
                prompttype();
                int input = int.Parse( Console.ReadLine());
                switch (input) 
                {
                    case (int)loanmenuCategory.business:
                        loanarr[count] = new BusinessLoan(i,customerFirstName, customerLastName, loanAmount, Term);break;
                    
                    case (int)loanmenuCategory.personal:
                        loanarr[count] = new PersonalLoan(i, customerFirstName, customerLastName, loanAmount, Term); break;

                  
                }
                input = 0;
                string line = "" +
                   "Please select option:\n" +
                   "1. Continue\n" +
                   "2. View recorded customers\n" +
                   "3. Exit";
                Console.WriteLine(line);
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1: break;
                    case 2: ToString(); break;
                    case 3: Environment.Exit(0); break;

                }
                count++;
                Console.Clear();

              

  
                    
            }

            void ToString()
            {
                Console.WriteLine("All loan details");
               for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(loanarr[i].ToString());
                }
            }
           



            void prompttype()
            {
                string line = "TERMS AND CONDITIONS APPLY. 1% will be added after " +
                    "Enter the type of loan you want for details entered\n";
                line += "1. Business Loan\n";
                line += "2. Individual Loan\n";
                Console.WriteLine(line);    
                
            }

    

            
         

        }

    }


}
