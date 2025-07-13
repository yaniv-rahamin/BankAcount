using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount currentAccount = new CheckingAccount(12345, 12, 123,02525 ,0, 500);
            SavingAccount providentFund = new SavingAccount(11, 222, 02525, 500, 0);
            double monthlyDeposit =providentFund.getMonthlyDeposit();
            if (currentAccount.Withrawal(monthlyDeposit))
                providentFund.MonthlyDeposit();
            else
                Console.WriteLine("The provident fund is in danger of closing");
        }
    }
}
