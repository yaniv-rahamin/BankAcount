using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    internal class SavingAccount
    {
        private int type, account, id, year;
        private double monthlyDeposit, balance;

        public SavingAccount(int type, int account, int id, double monthlyDeposit, double balance)
        {
            this.type = type;
            this.account = account;
            this.id = id;
            this.monthlyDeposit = monthlyDeposit;
            this.balance = balance;
            this.year = DateTime.Now.Year;
        }
        public int getType() { return this.type; }
        public int getAccount() { return this.account; }
        public int getId() { return this.id; }
        public double getMonthlyDeposit() { return this.monthlyDeposit; }
        public double getBalance() { return this.balance; }
        public int getYear() { return this.year; }

        public void setMonthlyDeposit(double monthlyDeposit)
        {
            this.monthlyDeposit = monthlyDeposit;
        }
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
    }

}
