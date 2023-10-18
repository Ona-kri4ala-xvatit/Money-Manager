using Money_Manager.Models;
using Money_Manager.Repositories.Base;
using Money_Manager.Services;
using MvvmApp.Commands.Base;
using MvvmApp.ViewModels.Base;
using System.Collections.ObjectModel;
using System;

namespace Money_Manager.ViewModels
{
    public class ExpensesViewModel : ViewModelBase
    {
        private readonly IAccountRepository accountRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly ITransactionRepository transactionRepository;

        private SharedDataCategories sharedDataCategories;
        private SharedDataAccounts sharedDataAccounts;

        #region Properties
        public ObservableCollection<Transaction> ExpensesTransactions { get; }
        public ObservableCollection<Account> Accounts { get; }
        public ObservableCollection<Category> ExpensesCategories { get; }

        private Account? selectedAccount;
        public Account? SelectedAccount { get => selectedAccount; set => base.PropertyChangeMethod(out selectedAccount, value); }

        private Category? selectedCategory;
        public Category? SelectedCategory { get => selectedCategory; set => base.PropertyChangeMethod(out selectedCategory, value); }

        private Transaction? selectedExpensesTransaction;
        public Transaction? SelectedExpensesTransaction { get => selectedExpensesTransaction; set => base.PropertyChangeMethod(out selectedExpensesTransaction, value); }

        private decimal money;
        public decimal Money { get => money; set => base.PropertyChangeMethod(out money, value); }

        private DateTime date;
        public DateTime Date { get => date; set => base.PropertyChangeMethod(out date, value); }
        #endregion

        #region Commands
        private CommandBase? saveExpensesCommand;
        public CommandBase? SaveExpensesCommand => this.saveExpensesCommand ??= new CommandBase(
            () =>
            {
                transactionRepository.CreateTransaction(new Transaction()
                {
                    Money = this.Money,
                    Date = this.Date.Date,
                    TransactionType = TransactionType.Expenses,
                    AccountId = SelectedAccount.Id,
                    CategoryId = SelectedCategory.Id
                });
                GetExpensesTransactions();
                accountRepository.UpdateAccountBalance(SelectedAccount.Id, this.Money, TransactionType.Expenses);
                this.Money = 0;
            },
            () => true);

        private CommandBase? deleteExpensesCommand;
        public CommandBase? DeleteExpensesCommand => this.deleteExpensesCommand ??= new CommandBase(
            () =>
            {
                if (SelectedExpensesTransaction is not null)
                {
                    transactionRepository.DeleteTransaction(SelectedExpensesTransaction.Id);
                }
                GetExpensesTransactions();
            },
            () => true);
        #endregion

        public ExpensesViewModel(IAccountRepository accountRepository, ICategoryRepository categoryRepository, ITransactionRepository transactionRepository, SharedDataCategories sharedDataCategories, SharedDataAccounts sharedDataAccounts)
        {
            this.accountRepository = accountRepository;
            this.categoryRepository = categoryRepository;
            this.transactionRepository = transactionRepository;

            this.sharedDataAccounts = sharedDataAccounts;
            this.sharedDataCategories = sharedDataCategories;

            this.ExpensesTransactions = new ObservableCollection<Transaction>();

            this.Accounts = sharedDataAccounts.Accounts;
            this.ExpensesCategories = sharedDataCategories.ExpensesCategories;

            this.Date = DateTime.Now;

            this.GetExpensesCategories();
            this.GetAccounts();
            this.GetExpensesTransactions();
        }

        private void GetExpensesCategories()
        {
            ExpensesCategories.Clear();
            var categories = categoryRepository.GetExpensesCategories();
            foreach (var category in categories)
            {
                ExpensesCategories.Add(category);
            }
        }

        private void GetAccounts()
        {
            Accounts.Clear();
            var accounts = accountRepository.GetAllAccounts();
            foreach (var account in accounts)
            {
                Accounts.Add(account);
            }
        }

        private void GetExpensesTransactions()
        {
            ExpensesTransactions.Clear();
            var expensesTransactions = transactionRepository.GetExpensesTransactions();
            foreach (var transaction in expensesTransactions)
            {
                ExpensesTransactions.Add(transaction);
            }
        }

    }
}
