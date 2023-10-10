using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Money_Manager.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string? AccountName { get; set; }
        public decimal Balance { get; set; }
        public string? Icon { get; set; }
        public string? Currency { get; set; } = "AZN";
        
    
        //public int TransactionId { get; set; }
        //public Transaction Transaction { get; set; }

        public Account() { }

        public Account(int id, string? name, decimal balance, string? icon)
        {
            this.Id = id;
            this.AccountName = name;
            this.Balance = balance;
            this.Icon = icon;
        }

        public Account(string? name, decimal balance, string? icon)
        {
            this.AccountName = name;
            this.Balance = balance;
            this.Icon = icon;
        }

        public Account(string name, decimal balance, string icon, string currency)
        {
            this.AccountName = name;
            this.Balance = balance;
            this.Icon = icon;
            this.Currency = currency;
        }

        public override string ToString()
        {
            return $"{AccountName}";
        }
    }
}
