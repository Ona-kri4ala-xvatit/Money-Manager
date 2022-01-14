using Money_Manager.Model;
using Money_Manager.View;

namespace Money_Manager.Presenter
{
    internal class MainFormPresenter
    {
        private Expenses expenses = new Expenses();
        private Budget budget = new Budget();
        private IViewDisplayBudget viewDisplayBudget;

        public MainFormPresenter(IViewDisplayBudget ViewDisplayBudget )
        {
            viewDisplayBudget = ViewDisplayBudget;
            
            RefreshBudget();
        }
       
        private void RefreshBudget()
        {
            viewDisplayBudget.DisplayBudget(budget.Balance);
        }
    }
}
