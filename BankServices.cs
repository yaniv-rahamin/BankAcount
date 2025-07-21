using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankAcount
{
    public class BankServices
    {
        #region fields
        private BasicAccount[] savingAccounts;
        int currentIndex;
        #endregion

        #region constructors
        public BankServices(int size)
        {
            savingAccounts = new BasicAccount[size];
            currentIndex = 0;

        }
        #endregion

        #region methods

        //תרגיל 12
        public SavingAccount[] ZeroSavings()
        {            
            SavingAccount[] zeroSavings = new SavingAccount[currentIndex];
            int index = 0;
            foreach (BasicAccount account in savingAccounts)
            {
                if (account is SavingAccount savingAccount && savingAccount.GetBalance() == 0)
                {
                    zeroSavings[index] = savingAccount;
                    index++;
                }
            }
            return zeroSavings;
        }
        //תרגיל 13
        public Node<string> LoanSuggestion()
        {
            Node<string> suggestions = null;
            foreach(BasicAccount account in savingAccounts)
            { 
                if(account is CheckingAccount && account.GetBalance()<((CheckingAccount)account).GetApprovedOverdraft()/2*-1)
                {
                   suggestions =new Node<string>($"Type: {account.GetType()} \nNumber Account: {account.GetAccount()} \nID: {account.GetId()} \nBalance: {account.GetBalance()} \nhas a low balance and may need a loan.\n",suggestions);  
                     

                }
            
            }
            return suggestions;        
        }




        public bool Add(BasicAccount account)
        {
            if (currentIndex < savingAccounts.Length)
            {
                savingAccounts[currentIndex] = account;
                currentIndex++;
                return true;
            }
            Console.WriteLine("No more space to add new accounts.");
            return false;

        }

        public string AccountDetail(int account)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (savingAccounts[i].GetAccount() == account)
                {
                    return savingAccounts[i].ToString();
                }
            }
            return "Account not found.";
        }

        public int TotalAccountsForAccountHoloder(int accountNum)
        {
            int id=-1;
            foreach (BasicAccount account in savingAccounts)
            {
                if (account.GetAccount() == accountNum)
                {
                    id = account.GetId();
                }
            }
            if (id == -1)
            {
                return 0;  
            }
            int count = 0;
            foreach (BasicAccount account in savingAccounts)
            {
                if (account.GetId() == id)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion

    }


}
