using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager.Model
{
    internal class Expenses //Расходы, затраты
    {
        private decimal food;               //еда
        private decimal health;             //здоровье 
        private decimal clothes;            //одежда
        private decimal entertainment;      //развлечения
        private decimal transportCosts;    //расходы на транспорт
        private decimal rentingProperties; //аренда жилья
        private decimal municipalServices; //коммунальные услуги
        private decimal debt;               //долги;
        private decimal other;              //другое

        public Expenses(decimal food, decimal health, decimal clothes, decimal entertainment, decimal transportCosts, decimal rentingProperties, decimal municipalServices, decimal debt, decimal other)
        {         
            Food = food;
            Health = health;
            Clothes = clothes;
            Entertainment = entertainment;
            TransportCosts = transportCosts;
            RentingProperties = rentingProperties;
            MunicipalServices = municipalServices;
            Debt = debt;
            Other = other;
        }

        public decimal Food
        {
            get { return food; }
            set 
            {
                if (food > 0) 
                { 
                    food = value;
                }
                else
                {
                    food = 0;
                }
            }
        }
        public decimal Health
        {
            get { return health; }
            set
            {
                if (health > 0)
                {
                    health = value;
                }
                else
                {
                    health = 0;
                }
            }
        }
        public decimal Clothes
        {
            get { return clothes; }
            set
            {
                if (clothes > 0)
                {
                    clothes = value;
                }
                else
                {
                    clothes = 0;
                }
            }
        }
        public decimal Entertainment
        {
            get { return entertainment; }
            set
            {
                if (entertainment > 0)
                {
                    entertainment = value;
                }
                else
                {
                    entertainment = 0;
                }
            }
        }
        public decimal TransportCosts
        {
            get { return transportCosts; }
            set
            {
                if (transportCosts > 0)
                {
                    transportCosts = value;
                }
                else
                {
                    transportCosts = 0;
                }
            }
        }
        public decimal RentingProperties
        {
            get { return rentingProperties; }
            set
            {
                if (rentingProperties > 0)
                {
                    rentingProperties = value;
                }
                else
                {
                    rentingProperties = 0;
                }
            }
        }
        public decimal MunicipalServices
        {
            get { return municipalServices; }
            set
            {
                if (municipalServices > 0)
                {
                    municipalServices = value;
                }
                else
                {
                    municipalServices = 0;
                }
            }
        }
        public decimal Debt
        {
            get { return debt; }
            set
            {
                if (debt > 0)
                {
                    debt = value;
                }
                else
                {
                    debt = 0;
                }
            }
        }
        public decimal Other
        {
            get { return other; }
            set
            {
                if (other > 0)
                {
                    other = value;
                }
                else
                {
                    other = 0;
                }
            }
        }

    }
}
