using Money_Manager.Context;
using Money_Manager.Models;
using Money_Manager.Repositories.Base;
using MvvmApp.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Money_Manager.ViewModels
{
    public class AccountsViewModel : ViewModelBase
    {
        private readonly IAccountRepository accountRepository;
        public ObservableCollection<Account> Accounts { get; set; }

        private Account? selectedAccount;
        public Account? SelectedAccount { get => selectedAccount; set => base.PropertyChangeMethod(out selectedAccount, value); }


        public AccountsViewModel(IAccountRepository repository)
        {
            this.accountRepository = repository;
            this.Accounts = new ObservableCollection<Account>();
            this.GetAccounts();

            //Accounts = new ObservableCollection<Account>(accountRepository.GetAllAccounts());
        }

        public void GetAccounts()
        { 
            var acc = accountRepository.GetAllAccounts();

            foreach (var item in acc)
            {
                Accounts.Add(item);
            }
        }


    }
}
