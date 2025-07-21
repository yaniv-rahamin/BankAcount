using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public class SavingAccount : BasicAccount
    {
        #region fields
        private int type, year;
        private double monthlyDeposit;
        #endregion 

        #region constructors    
        public SavingAccount(int type, int account, int id, int bankBranch, int bank, double monthlyDeposit, double balance):base(account, id,bankBranch,bank ,balance)
        {
            this.type = type;          
            this.monthlyDeposit = monthlyDeposit;
            this.year = DateTime.Now.Year;
        }
        #endregion

        #region getters 
        public int getType() { return this.type; }       
        public double getMonthlyDeposit() { return this.monthlyDeposit; }
        public int getYear() { return this.year; }
        #endregion

        #region setters 
        public void setMonthlyDeposit(double monthlyDeposit)
        {
            this.monthlyDeposit = monthlyDeposit;
        }
        #endregion

        #region mathods
        public void MonthlyDeposit()
        {
            this.balance += monthlyDeposit;
        }
        public int expiration()
        {
            if (DateTime.Now.Year - year <= 15)
                return DateTime.Now.Year - year;
            return 0;
        }
        

        #endregion




        #region ToString
        public override string ToString()
        {
            return $"Type: {type}, Monthly Deposit: {monthlyDeposit}, Year: {year}" + base.ToString();
        }
        #endregion  
    }

}
