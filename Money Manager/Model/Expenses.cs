using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager.Model
{
    internal class Expenses //Расходы, затраты
    {
        private decimal balance;            //общий бюджет
        private decimal food;               //еда
        private decimal health;             //здоровье 
        private decimal clothes;            //одежда
        private decimal entertainment;      //развлечения
        private decimal transport_costs;    //расходы на транспорт
        private decimal rental_of_property; //аренда жилья
        private decimal municipal_services; //коммунальные услуги
        private decimal debt;               //долги;
        private decimal other;              //другое

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

       
    }
}
