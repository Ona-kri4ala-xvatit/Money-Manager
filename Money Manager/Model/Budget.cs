using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager.Model
{
    internal class Budget //общий бюджет
    {
        private decimal balance;
        private DateTime balanceDate;

        //public Budget()
        //{
        //    balance = 0;
        //    balanceDate = new DateTime();
        //}

        //public Budget(decimal balance, DateTime dateTime)
        //{
        //    Balance = balance;
        //    balanceDate = dateTime;
        //}

        public decimal Balance
        {
            get { return balance; }
            set
            {
                balance = value;
                //if (balance > 0)
                //{
                //    balance = value;
                //}
                //else
                //{
                //    balance = 0;
                //}
            }
        }

        public DateTime BalanceDate
        {
            get { return balanceDate; }
            set { balanceDate = value; }
        }
    }

}
