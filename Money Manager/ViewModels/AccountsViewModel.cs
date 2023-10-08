using Money_Manager.Context;
using Money_Manager.Models;
using MvvmApp.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Money_Manager.ViewModels
{
    public class AccountsViewModel : ViewModelBase
    {
        //private string? accountName;

        //public string? AccountName
        //{
        //	get => accountName;
        //	set { base.PropertyChangeMethod(out accountName, value); }
        //}

        private readonly MoneyManagerDbContext managerDbContext;
         
        public ObservableCollection<Account> Accounts { get; set; }

        public AccountsViewModel()
        {
            managerDbContext = new MoneyManagerDbContext();
            var result = managerDbContext.Accounts.ToList();
            Accounts = new ObservableCollection<Account>(result);
         

            //Accounts.Add(new Account(1, "Main", 100500, "Wallet"));
            //Accounts.Add(new Account(2, "Second", 100, "Cash"));
        }

       
    }
}
