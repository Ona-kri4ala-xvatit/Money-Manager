﻿using Money_Manager.Models;
using Money_Manager.Repositories;
using Money_Manager.Repositories.Base;
using Money_Manager.Services;
using MvvmApp.Commands.Base;
using MvvmApp.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Money_Manager.ViewModels
{
    public class IncomeViewModel : ViewModelBase
    {
        private readonly IAccountRepository accountRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly ITransactionRepository transactionRepository;
        private readonly TransactionDapperRepository transactionDapperRepository;

        private readonly SharedDataCategories sharedDataCategories;
        private readonly SharedDataAccounts sharedDataAccounts;

        #region Properties
        public ObservableCollection<Transaction> IncomeTransactions { get; }
        public ObservableCollection<Account> Accounts { get; }
        public ObservableCollection<Category> IncomeCategories { get; }

        private Account? selectedAccount;
        public Account? SelectedAccount { get => selectedAccount; set => base.PropertyChangeMethod(out selectedAccount, value); }

        private Category? selectedCategory;
        public Category? SelectedCategory { get => selectedCategory; set => base.PropertyChangeMethod(out selectedCategory, value); }

        private Transaction? selectedIncomeTransaction;
        public Transaction? SelectedIncomeTransaction { get => selectedIncomeTransaction; set => base.PropertyChangeMethod(out selectedIncomeTransaction, value); }

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
                if (SelectedAccount is not null && SelectedCategory is not null && Money != 0)
                {
                    transactionRepository.CreateTransaction(new Transaction()
                    {
                        Money = this.Money,
                        Date = this.Date.Date,
                        TransactionType = TransactionType.Income,
                        AccountId = SelectedAccount.Id,
                        CategoryId = SelectedCategory.Id
                    });
                    accountRepository.UpdateAccountBalance(SelectedAccount.Id, this.Money, TransactionType.Income);
                    SelectedAccount = null;
                    SelectedCategory = null;
                    this.Money = 0;
                }
                GetIncomeTransactions();
            },
            () => true);

        private CommandBase? deleteIncomeCommand;
        public CommandBase? DeleteIncomeCommand => this.deleteIncomeCommand ??= new CommandBase(
            () =>
            {
                if (SelectedIncomeTransaction is not null)
                {
                    accountRepository.UpdateAccountAfterDeleteTransaction(SelectedIncomeTransaction.AccountId, SelectedIncomeTransaction.Money);
                    transactionRepository.DeleteTransaction(SelectedIncomeTransaction.Id);
                    GetIncomeTransactions();
                }
            },
            () => true);

        private CommandBase? saveToFileIncomeCommand;
        public CommandBase? SaveToFileIncomeCommand => this.saveToFileIncomeCommand ??= new CommandBase(
            () =>
            {
                this.SaveTransactions();
            },
            () => true);
        #endregion

        public IncomeViewModel(IAccountRepository accountRepository, ICategoryRepository categoryRepository, ITransactionRepository transactionRepository,
            SharedDataCategories sharedDataCategories, SharedDataAccounts sharedDataAccounts, TransactionDapperRepository transactionDapperRepository)
        {
            this.accountRepository = accountRepository;
            this.categoryRepository = categoryRepository;
            this.transactionRepository = transactionRepository;

            this.transactionDapperRepository = transactionDapperRepository;

            this.sharedDataAccounts = sharedDataAccounts;
            this.sharedDataCategories = sharedDataCategories;

            this.IncomeTransactions = new ObservableCollection<Transaction>();

            this.Accounts = sharedDataAccounts.Accounts;
            this.IncomeCategories = sharedDataCategories.IncomeCategories;

            this.Date = DateTime.Now;

            this.GetIncomeCategories();
            this.GetAccounts();
            this.GetIncomeTransactions();
        }

        private void GetIncomeCategories()
        {
            IncomeCategories.Clear();
            var categories = categoryRepository.GetIncomeCategories();
            foreach (var category in categories)
            {
                IncomeCategories.Add(category);
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

        private void GetIncomeTransactions()
        {
            IncomeTransactions.Clear();
            var incomeTransactions = transactionRepository.GetIncomeTransactions();
            foreach (var transaction in incomeTransactions)
            {
                IncomeTransactions.Add(transaction);
            }
        }

        private void SaveTransactions()
        {
            var result = transactionDapperRepository.GetAllTransactionsToSave();

            var filecontents = string.Join(Environment.NewLine, result);
            File.WriteAllText("Transaction.txt", filecontents);

            //foreach (var item in resp)
            //{
            //    File.AppendAllText("Transaction.txt", item.ToString());
            //}
        }
    }
}
