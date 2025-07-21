using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankAcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount currentAccount = new CheckingAccount(12345, 12, 123, 02525, 0, 500);
            SavingAccount providentFund = new SavingAccount(11, 222, 02525, 56, 65, 500, 0);
            double monthlyDeposit = providentFund.getMonthlyDeposit();
            if (currentAccount.Withrawal(monthlyDeposit))
                providentFund.MonthlyDeposit();
            else
                Console.WriteLine("The provident fund is in danger of closing");

            BusinessAccount businessAccount = new BusinessAccount("Tech Solutions", 12345, 12, 123, 02525, 1000, 500);
            bool isBusinessAccountWithdrawalSuccessful = businessAccount.Withrawal(200);
            Console.WriteLine("isBusinessAccountWithdrawalSuccessful:" + isBusinessAccountWithdrawalSuccessful);
            businessAccount.Deposit(300);
            Console.WriteLine($"balance: {businessAccount.GetBalance()}");
            Console.WriteLine(businessAccount.SalaryPayment(50,currentAccount));
            


        }
      
                            
    }
}
