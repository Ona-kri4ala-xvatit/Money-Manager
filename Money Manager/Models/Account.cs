using System.Collections.Generic;

namespace Money_Manager.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string? AccountName { get; set; }
        public decimal Balance { get; set; }
        public string? Icon { get; set; }
        public string? Currency { get; set; } = "AZN";
        public IList<Transaction> Transaction { get; set; }
        public Account() { }

        public override string ToString()
        {
            return $"{AccountName}";
        }
    }
}
