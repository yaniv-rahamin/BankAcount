using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    internal class CheckingAccount  
    {
        private int account, bankBranch, bank, id;
        private double balance, approvedOverdraft;

        public CheckingAccount(int account, int bankBranch, int bank, int id, int balance, int approvedOverdraft)
        {
            this.account = account;
            this.bankBranch = bankBranch;
            this.bank = bank;
            this.id = id;
            this.balance = balance;
            this.approvedOverdraft = approvedOverdraft;
        }

        public int GetAccount()
        { return this.account; }
        public int GetBankBranch()
        { return this.bankBranch; }
        public int GetId()
        { return this.id; }
        public double GetBalance()
        { return this.balance; }
        public double GetApprovedOverdraft()
        { return this.approvedOverdraft; }
        public int GetBank()
        { return this.bank; }

       
        public void SetBankBranch(int bankBranch)
        { this.bankBranch = bankBranch; }
        public void SetApprovedOverdraft(double approvedOverdraft) 
        { this.approvedOverdraft = approvedOverdraft; }
        
        public void Deposit(double Deposit)
        {
            this.balance = Deposit;
          
        }
        public bool Withrawal(double withrawal)
        {
            if(WithrawalAllowed()-withrawal>=0)
                return true;
            return false;
        }

        private double WithrawalAllowed()
        {
            return this.balance+approvedOverdraft; 
        }








    }
}
