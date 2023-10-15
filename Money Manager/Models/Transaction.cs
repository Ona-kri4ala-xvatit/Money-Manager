using Money_Manager.Services;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Money_Manager.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public TransactionType TransactionType { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountId { get; set; }
        public Account? Account { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }


        public Transaction() { }

        //public Transaction(decimal money, DateTime date, Account? account, Category? category, TransactionType type)
        //{
        //    this.Money = money;
        //    this.Date = date;
        //    this.Account = account;
        //    this.Category = category;
        //    this.TransactionType = type;
        //}

        //public Transaction(decimal money, DateTime date, Account? account, Category? category)
        //{
        //    this.Money = money;
        //    this.Date = date;
        //    this.Account = account;
        //    this.Category = category;
        //}


    }
}
