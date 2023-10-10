using Money_Manager.Models;
using Money_Manager.Repositories.Base;
using Money_Manager.Services;
using MvvmApp.Commands.Base;
using MvvmApp.ViewModels.Base;
using System;
using System.Collections.ObjectModel;

namespace Money_Manager.ViewModels
{
    public class IncomeViewModel : ViewModelBase
    {
        private readonly IAccountRepository accountRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IIncomeRepository incomeRepository;

        #region Properties
        public ObservableCollection<Account> Accounts { get; set; } = new ObservableCollection<Account>();
        public ObservableCollection<Category> Categories { get; set; } = new ObservableCollection<Category>();

        private Account? selectedAccount;
        public Account? SelectedAccount { get => selectedAccount; set => base.PropertyChangeMethod(out selectedAccount, value); }

        private Category? selectedCategory;
        public Category? SelectedCategory { get => selectedCategory; set => base.PropertyChangeMethod(out selectedCategory, value); }

        private decimal money;
        public decimal Money { get => money; set => base.PropertyChangeMethod(out money, value); }

        private DateTime date;
        public DateTime Date { get => date; set => base.PropertyChangeMethod(out date, value); }
        #endregion

        #region Commands
        private CommandBase? saveIncomeCommand;
        public CommandBase? SaveIncomeCommand => this.saveIncomeCommand ??= new CommandBase(
            () =>
            {
                incomeRepository.CreateIncomeTransaction(new Transaction()
                {
                    Money = this.Money,
                    Date = this.Date,
                    TransactionType = TransactionType.Income,
                    Account = SelectedAccount,
                    Category = SelectedCategory
                });

                this.Money = 0;


            },
            () => true);
        #endregion


        public IncomeViewModel(IAccountRepository AccountRepository, ICategoryRepository CategoryRepository, IIncomeRepository IncomeRepository)
        {
            Date = DateTime.Now;

            this.accountRepository = AccountRepository;
            this.categoryRepository = CategoryRepository;
            this.incomeRepository = IncomeRepository;


            this.PrintIncomeCategories();
            this.PrintAccounts();
        }

        private void PrintIncomeCategories()
        {
            var categories = categoryRepository.GetIncomeCategories();
            foreach (var category in categories)
            {
                Categories.Add(category);
            }
        }

        private void PrintAccounts()
        {
            var accounts = accountRepository.GetAllAccounts();
            foreach (var account in accounts)
            {
                Accounts.Add(account);
            }
        }
    }
}
