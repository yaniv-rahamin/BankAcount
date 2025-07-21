using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public class BusinessAccount : CheckingAccount
    {
        #region fields
        private string businessName;
        #endregion

        #region constructors
        public BusinessAccount(string businessName, int account, int bankBranch, int bank, int id, double balance, double approvedOverdraft) : base(account, bankBranch, bank, id, balance, approvedOverdraft)
        {
            this.businessName = businessName;
        }
        #endregion

        #region getters
        public string GetBusinessName()
        {
            return this.businessName;
        }
        #endregion

        #region methods
        public bool SalaryPayment(int payment, CheckingAccount account)
        {
            if (!Withrawal(payment))
                return false;
            else
            {
                account.Deposit(payment);
                return true;
            }
        }
        #endregion

        #region ToString    
        public override string ToString()
        {
            return $"businessName: {businessName}" + base.ToString();
        }
        #endregion

    }
}
