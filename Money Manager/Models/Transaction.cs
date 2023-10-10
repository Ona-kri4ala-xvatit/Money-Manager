using Money_Manager.Services;
using System;

namespace Money_Manager.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public Account? Account { get; set; }
        public Category? Category { get; set; }
        public TransactionType TransactionType { get; set; }


        //public ICollection<Category> Categories { get; set; }

        //public ICollection<Account> Accounts { get; set; }

        public Transaction() { }

        public Transaction(decimal money, DateTime date, Account? account, Category? category, TransactionType type)
        {
            this.Money = money;
            this.Date = date;
            this.Account = account;
            this.Category = category;
            this.TransactionType = type;
        }

        public Transaction(decimal money, DateTime date, Account? account, Category? category)
        {
            this.Money = money;
            this.Date = date;
            this.Account = account;
            this.Category = category;
        }


    }
}
