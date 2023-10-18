using Money_Manager.Models;
using System.Collections.Generic;

namespace Money_Manager.Repositories.Base
{
    public interface ITransactionRepository
    {
        public void CreateTransaction(Transaction transaction);
        public void DeleteTransaction(int id);
        public IEnumerable<Transaction> GetIncomeTransactions();
        public IEnumerable<Transaction> GetExpensesTransactions();
    }
}
