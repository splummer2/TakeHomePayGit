using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomePayGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables first

            string employeeName = "Jessica Oakley";
            double salesThisWeek = 28000;
            double federalTax;
            double socialSecurity;
            double commission;
            double retirement;
            double netPay;

            //This is where the processing is done

            commission = (double)salesThisWeek * .07;
            federalTax = (double)commission * .18;
            retirement = (double)commission * .10;
            socialSecurity = (double)commission * .06;
            netPay = (double)commission - federalTax - socialSecurity - retirement;

            //This is where the output is done
            //This part goes to the black screen.

            Console.WriteLine(" Take Home Pay for {0:c} \n", employeeName);
            Console.WriteLine(" Your commission is {0:c} \n", commission);
            Console.WriteLine(" Your federal tax is {0:c} \n", federalTax);
            Console.WriteLine(" Your retirement is {0:c} \n", retirement);
            Console.WriteLine(" Your social security is {0:c} \n", socialSecurity);
            Console.WriteLine(" Your net pay is {0:c} \n", netPay);


            Console.Read();
        }
    }
}
