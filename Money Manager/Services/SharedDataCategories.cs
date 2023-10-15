using Money_Manager.Models;
using System.Collections.ObjectModel;

namespace Money_Manager.Services
{
    public class SharedDataCategories
    {
        private ObservableCollection<Category> categories = new ObservableCollection<Category>();

        public ObservableCollection<Category> Categories
        {
            get => categories;
        }
    }
}
