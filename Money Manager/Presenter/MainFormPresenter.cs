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
        private Interface view;

        public MainFormPresenter(Interface _view)
        {
            view = _view;
            sd();
        }

        private void sd()
        {
            view.ShowdData(budget.Balance);
        }
        


        
        
    }
}
