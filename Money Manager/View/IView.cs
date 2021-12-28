using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager.View
{
    internal interface IView
    {  
        void SetBudget(decimal value);
        void SetFood(decimal value);
        void SetHealth(decimal value);
        void SetClothes(decimal value);
        void SetDebt(decimal value);
        void SetOther(decimal value);
        void SetEntertainment(decimal value);
        void SetTransportCosts(decimal value);
        void SetMunicipalService(decimal value);

        void SetRentingProperties(decimal value);
    }
}
