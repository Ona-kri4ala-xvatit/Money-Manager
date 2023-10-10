using Money_Manager.Models;
using Money_Manager.Repositories.Base;
using MvvmApp.Commands.Base;
using MvvmApp.Mediator.Base;
using MvvmApp.Messages;
using MvvmApp.ViewModels.Base;
using System.Collections.ObjectModel;

namespace Money_Manager.ViewModels
{
    public class AccountsViewModel : ViewModelBase
    {
        private readonly IAccountRepository accountRepository;
        public static ObservableCollection<string> Icons { get; set; } = new ObservableCollection<string>()
        {
             "Cash","Wallet","Bank","PiggyBankOutline","CreditCardOutline","CurrencyEur","WalletGiftcard","CurrencyUsd","CurrencyGbp"
        };
        public ObservableCollection<Account> Accounts { get; set; }

        #region Properties
        private string? selectedIcon;
        public string? SelectedIcon
        {
            get => selectedIcon;
            set
            {
                base.PropertyChangeMethod(out selectedIcon, value);
            }
        }

        private decimal balance;
        public decimal Balance
        {
            get => balance;
            set
            {
                base.PropertyChangeMethod(out balance, value);
            }
        }

        private string? accountName;
        public string? AccountName
        {
            get => accountName;
            set
            {
                base.PropertyChangeMethod(out accountName, value);
            }
        }
        #endregion

        #region Commands
        private CommandBase? saveAccountCommand;
        public CommandBase? SaveAccountCommand => this.saveAccountCommand ??= new CommandBase(
            () =>
            {
                accountRepository.CreateAccount(new Account()
                {
                    AccountName = this.AccountName,
                    Balance = this.Balance,
                    Icon = this.SelectedIcon
                });
                this.AccountName = string.Empty;
                this.Balance = 0;
                Accounts = new ObservableCollection<Account>(accountRepository.GetAllAccounts());
            },
            () => true);
        #endregion

        public AccountsViewModel(IAccountRepository repository)
        {
            this.accountRepository = repository;
            this.Accounts = new ObservableCollection<Account>();
            this.PrintAccounts();
        }


        public void PrintAccounts()
        {
            var accounts = accountRepository.GetAllAccounts();

            foreach (var account in accounts)
            {
                Accounts.Add(account);
            }
        }


    }
}
