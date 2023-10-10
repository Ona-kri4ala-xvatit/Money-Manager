using Money_Manager.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace Money_Manager.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public TransactionType TransactionType { get; set; }
        public string? Icon { get; set; }

     
        //public int TransactionId { get; set; }
        //public Transaction Transaction { get; set; }

        public Category() { }
        public Category(string name, TransactionType type, string icon)
        {
            this.CategoryName = name;
            this.TransactionType = type;
            this.Icon = icon;
        }

        public Category(string name, string icon)
        {
            this.CategoryName = name;
            this.Icon = icon;
        }

        public Category(TransactionType type)
        {
            this.TransactionType = type;
        }
    }
}
