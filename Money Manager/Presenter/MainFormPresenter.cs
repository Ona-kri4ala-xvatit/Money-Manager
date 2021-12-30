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
            view.GetBudget += new EventHandler<EventArgs>(Presenter_SetBudget);
            RefreshBudget();
        }


        private void Presenter_SetBudget(object sender, EventArgs e)
        {
            budget.Balance = view.InputBudget;
            RefreshBudget();
        }
        private void RefreshBudget()
        {
            view.SetBudget(budget.Balance);

        }


    }
}
