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
            GetExpenses();
        }

        private void GetBudget()
        {
            view.SetBudget(budget.Balance);
        }

        private void GetExpenses()
        {
            view.SetFood(expenses.Food);
        }
        


        
        
    }
}
