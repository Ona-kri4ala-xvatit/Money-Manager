using Money_Manager.Model;
using Money_Manager.View;

namespace Money_Manager.Presenter
{
    internal class MainFormPresenter
    {
        private Expenses expenses = new Expenses();
        private Budget budget = new Budget();
        private IViewDisplayBudget viewDisplayBudget;
        private IViewInputBudget viewInputBudget;


        public MainFormPresenter(IViewDisplayBudget ViewDisplayBudget, IViewInputBudget ViewInputBudget)
        {
            viewInputBudget = ViewInputBudget;
            viewDisplayBudget = ViewDisplayBudget;
            viewInputBudget.GetBudget += new EventHandler<EventArgs>(Presenter_GetBudget);
            RefreshBudget();
        }

        private void Presenter_GetBudget(object sender, EventArgs e)
        {
            budget.Balance = viewInputBudget.InputBudget;
            RefreshBudget();
        }
        private void RefreshBudget()
        {
            viewDisplayBudget.DisplayBudget(budget.Balance);
        }


    }
}
