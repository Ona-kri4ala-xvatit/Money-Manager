using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Money_Manager.Model;
using Money_Manager.View;

namespace Money_Manager.Presenter
{
    internal class MainFormPresenter
    {
        private Expenses expenses = new Expenses();
        private Budget budget = new Budget();
        private IView view;

        public MainFormPresenter(IView Iview)
        {
            view = Iview;
            GetBudget();
            GetFood();
            GetHealth();
            GetClothes();
            GetDebt();
            GetOther();
            GetEntertainment();
            GetTransportCosts();
            GetMunicipalService();
            GetRentingProperties();
        }

        private void GetBudget()
        {
            view.SetBudget(budget.Balance);
        }

        private void GetFood()
        {
            view.SetFood(expenses.Food);
        }

        private void GetHealth()
        {
            view.SetHealth(expenses.Health);
        }
        
        private void GetClothes()
        {
            view.SetClothes(expenses.Clothes);
        }

        private void GetDebt()
        {
            view.SetDebt(expenses.Debt);
        }

        private void GetOther()
        {
            view.SetOther(expenses.Other);
        }
        
        private void GetEntertainment()
        {
            view.SetEntertainment(expenses.Entertainment);
        }

        private void GetTransportCosts()
        {
            view.SetTransportCosts(expenses.TransportCosts);
        }

        private void GetMunicipalService()
        {
            view.SetMunicipalService(expenses.MunicipalServices);
        }

        private void GetRentingProperties()
        {
            view.SetRentingProperties(expenses.RentingProperties);  
        }

        
        
    }
}
