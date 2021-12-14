using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager.Model
{
    internal class Budget
    {
        private decimal balance;            //общий бюджет

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (balance > 0)
                {
                    balance = value;
                }
                else
                {
                    balance = 0;
                }
            }
        }

        public Budget(decimal balance)
        {
            Balance = balance;
        }
    }

}
