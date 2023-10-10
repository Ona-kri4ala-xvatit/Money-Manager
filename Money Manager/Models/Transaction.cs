using System;
using Money_Manager.Services;

namespace Money_Manager.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public Account? Account { get; set; }
        public TransactionType TransactionType { get; set; }
        public string? Icon { get; set; }
        
        public Transaction() {}

    }
}
