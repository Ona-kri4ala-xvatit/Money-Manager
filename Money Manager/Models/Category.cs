using Money_Manager.Services;
using System.Collections.Generic;

namespace Money_Manager.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public TransactionType TransactionType { get; set; }
        public string? Icon { get; set; }
        public IList<Transaction> Transaction { get; set; }

        public Category() { }
    }
}
