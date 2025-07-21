using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankAcount
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CheckingAccount currentAccount = new CheckingAccount(12345, 12, 123, 02525, 0, 500);
            //SavingAccount providentFund = new SavingAccount(11, 222, 02525, 56, 65, 500, 0);
            //double monthlyDeposit = providentFund.getMonthlyDeposit();
            //if (currentAccount.Withrawal(monthlyDeposit))
            //    providentFund.MonthlyDeposit();
            //else
            //    Console.WriteLine("The provident fund is in danger of closing");

            //BusinessAccount businessAccount = new BusinessAccount("Tech Solutions", 12345, 12, 123, 02525, 1000, 500);
            //bool isBusinessAccountWithdrawalSuccessful = businessAccount.Withrawal(200);
            //Console.WriteLine("isBusinessAccountWithdrawalSuccessful:" + isBusinessAccountWithdrawalSuccessful);
            //businessAccount.Deposit(300);
            //Console.WriteLine($"balance: {businessAccount.GetBalance()}");
            //Console.WriteLine(businessAccount.SalaryPayment(50,currentAccount));

            SavingAccount providentFund1 = new SavingAccount(11, 222, 02525, 56, 65, 500, 0);
            SavingAccount providentFund2 = new SavingAccount(11, 223, 02526, 56, 65, 500, 100);   
            SavingAccount providentFund3 = new SavingAccount(11, 224, 02527, 56, 65, 500, 0);

            CheckingAccount currentAccount1 = new CheckingAccount(12345, 12, 123, 02525, 100, 200);
            CheckingAccount currentAccount2 = new CheckingAccount(12346, 12, 123, 02526, -110, 200);
            CheckingAccount currentAccount3 = new CheckingAccount(12347, 12, 123, 02527, 130, 200);
            CheckingAccount currentAccount4 = new CheckingAccount(12348, 12, 123, 02528, -70, 200);
            CheckingAccount currentAccount5 = new CheckingAccount(12349, 12, 123, 02529, -130, 200);
            BankServices bankServices = new BankServices(15);
            bankServices.Add(currentAccount1);
            bankServices.Add(currentAccount2);
            bankServices.Add(currentAccount3);
            bankServices.Add(currentAccount4);
            bankServices.Add(currentAccount5);
            bankServices.Add(providentFund1);
            bankServices.Add(providentFund2);
            bankServices.Add(providentFund3);

            SavingAccount[] zeroSavings = bankServices.ZeroSavings();   
            foreach (SavingAccount account in zeroSavings) 
            {
                if(account != null) 
                    Console.WriteLine(account.GetId());
            }
            Node<string> suggestions = bankServices.LoanSuggestion();
           while (suggestions != null)
            {
                Console.WriteLine(suggestions.GetItem());
                suggestions = suggestions.GetNext();
            }
            
        }
        

    }
}
