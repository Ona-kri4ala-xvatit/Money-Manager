using Money_Manager.Models;
using System.Collections.ObjectModel;

namespace Money_Manager.Services
{
    public class SharedDataAccounts
    {
        private ObservableCollection<Account> accounts = new ObservableCollection<Account>();

        public ObservableCollection<Account> Accounts
        {
            get => accounts;
        }
    }
}
