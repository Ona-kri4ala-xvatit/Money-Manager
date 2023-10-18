using Money_Manager.Models;
using System.Collections.ObjectModel;

namespace Money_Manager.Services
{
    public class SharedDataCategories
    {
        private ObservableCollection<Category> incomeCategories = new ObservableCollection<Category>();

        public ObservableCollection<Category> IncomeCategories
        {
            get => incomeCategories;
        }

        private ObservableCollection<Category> expensesCategories = new ObservableCollection<Category>();

        public ObservableCollection<Category> ExpensesCategories
        {
            get => expensesCategories;
        }
    }
}
