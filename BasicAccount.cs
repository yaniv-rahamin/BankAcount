using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public class BasicAccount
    {
        #region fields
       protected int account, bankBranch, bank, id;
        protected double balance;
        #endregion

        #region constructors
        public BasicAccount(int account, int bankBranch, int bank, int id, double balance)
        {
            this.account = account;
            this.bankBranch = bankBranch;
            this.bank = bank;
            this.id = id;
            this.balance = balance;
        }
        #endregion

        #region getters
        public int GetAccount() { return this.account; }    
        public int GetBankBranch() { return this.bankBranch; }  
        public int GetBank() { return this.bank; }
        public int GetId() { return this.id; }  
        public double GetBalance() { return this.balance; }
        #endregion

        #region setters
        public void SetAccount(int account) { this.account = account; }
        public void SetBankBranch(int bankBranch) { this.bankBranch = bankBranch; }
        public void SetBank(int bank) { this.bank = bank; }
        public void SetId(int id) { this.id = id; }
        public void SetBalance(double balance) { this.balance = balance; }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $"Account: {account}, Bank Branch: {bankBranch}, Bank: {bank}, ID: {id}, Balance: {balance}";
        }
        #endregion  
    }
}
