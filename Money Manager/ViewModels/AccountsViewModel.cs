using Money_Manager.Models;
using Money_Manager.Repositories.Base;
using Money_Manager.Services;
using MvvmApp.Commands.Base;
using MvvmApp.ViewModels.Base;
using System.Collections.ObjectModel;

namespace Money_Manager.ViewModels
{
    public class AccountsViewModel : ViewModelBase
    {
        private readonly IAccountRepository accountRepository;
        private readonly SharedDataAccounts sharedDataAccounts;
        public static ObservableCollection<string> Icons { get; set; } = new ObservableCollection<string>()
        {
             "Cash","Wallet","Bank","PiggyBankOutline","CreditCardOutline","CurrencyEur","WalletGiftcard","CurrencyUsd","CurrencyGbp"
        };

        #region Properties
        public ObservableCollection<Account> Accounts { get; set; }

        private Account? selectedAccount;
        public Account? SelectedAccount { get => selectedAccount; set => base.PropertyChangeMethod(out selectedAccount, value); }

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

                this.GetAccounts();
            },
            () => true);

        private CommandBase? deleteAccountCommand;
        public CommandBase? DeleteAccountCommand => this.deleteAccountCommand ??= new CommandBase(
        () =>
        {
            if (SelectedAccount is not null)
            {
                accountRepository.DeleteAccount(SelectedAccount.Id);
            }

            this.GetAccounts();
        },
            () => true);
        #endregion

        public AccountsViewModel(IAccountRepository repository, SharedDataAccounts sharedDataAccounts)
        {
            this.sharedDataAccounts = sharedDataAccounts;
            this.Accounts = sharedDataAccounts.Accounts;

            this.accountRepository = repository;
            GetAccounts();
        }

        public void GetAccounts()
        {
            Accounts.Clear();
            var accounts = accountRepository.GetAllAccounts();

            foreach (var account in accounts)
            {
                Accounts.Add(account);
            }
        }
    }
}
