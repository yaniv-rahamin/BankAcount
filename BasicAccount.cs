using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    internal class BasicAccount
    {
        #region fields  
        protected int account, id, bankBranch, bank;
        protected double balance;
        #endregion

        #region constructors       
        public BasicAccount(int account, int id, int bankBranch, int bank, double balance)
        {
            this.account = account;
            this.id = id;
            this.bankBranch = bankBranch;
            this.bank = bank;
            this.balance = balance;
        }
        #endregion

        #region getters
        public int GetAccount() { return this.account; }
        public int GetId() { return this.id; }
        public double GetBalance() { return this.balance; }
        public int GetBank() { return this.bank; }  
        public int GetBankBranch()  { return this.bankBranch; }
        #endregion

        #region Setters
        public void SetBankBranch(int bankBranch)
        { this.bankBranch = bankBranch; }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $"Account: {account}, ID: {id}, Bank Branch: {bankBranch}, Bank: {bank}, Balance: {balance}";
        }   
        #endregion




    }
}
