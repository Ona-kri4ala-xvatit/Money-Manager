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

        public override string ToString()
        {
            return $"{TransactionType} Date: {Date.ToLongDateString()}; Money: {Money}";
        }
    }
}
