using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public class CheckingAccount:BasicAccount
    {
        #region fields
        protected double approvedOverdraft;
        #endregion

        #region constructors
        public CheckingAccount(int account, int bankBranch, int bank, int id, double balance, double approvedOverdraft) : base(account, id, bankBranch, bank, balance)
        {

            this.approvedOverdraft = approvedOverdraft;
        }
        #endregion

        #region getters
        public double GetApprovedOverdraft()
        { return this.approvedOverdraft; }
        #endregion

        #region setters
        public void SetApprovedOverdraft(double approvedOverdraft)
        { this.approvedOverdraft = approvedOverdraft; }
        #endregion

        #region methods
        public void Deposit(double Deposit)
        {
            if (Deposit < 0)
            {
                Console.WriteLine("Deposit amount cannot be negative.");
                return;
            }
            this.balance += Deposit;

        }
        public bool Withrawal(double withrawal)
        {
            if (this.balance + approvedOverdraft - withrawal >= 0)
            {
                balance -= withrawal;
                return true;
            }

            return false;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $"Approved Overdraft: {approvedOverdraft}" + base.ToString();
        }
        #endregion  










    }
}
