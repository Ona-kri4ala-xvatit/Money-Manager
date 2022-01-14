using Money_Manager.Model;
using Money_Manager.View;

namespace Money_Manager.Presenter
{
    internal class AddBudgetFormPresenter
    {
        private Budget budget = new Budget();
        private IViewInputBudget viewInputBudget;
         
        public AddBudgetFormPresenter(IViewInputBudget ViewInputBudget)
        {
            viewInputBudget = ViewInputBudget;
            viewInputBudget.GetBudget += new EventHandler<EventArgs>(Presenter_GetBudget);
        }

        private void Presenter_GetBudget(object? sender, EventArgs e)
        {
            budget.Balance = viewInputBudget.InputBudget;
            //RefreshBudget();
            //viewDisplayBudget.DisplayBudget(budget.Balance);
        }
    }
}
