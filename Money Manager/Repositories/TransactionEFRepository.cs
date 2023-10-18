using Money_Manager.Context;
using Money_Manager.Models;
using Money_Manager.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace Money_Manager.Repositories
{
    public class TransactionEFRepository : ITransactionRepository
    {
        private readonly MoneyManagerDbContext dbContext;
        public TransactionEFRepository(MoneyManagerDbContext moneyManagerDbContext) => this.dbContext = moneyManagerDbContext;

        public void CreateTransaction(Transaction transaction)
        {
            dbContext.Transactions.Add(transaction);
            dbContext.SaveChanges();
        }

        public void DeleteTransaction(int id)
        {
            var transactionToDelete = dbContext.Transactions.FirstOrDefault(x => x.Id == id);

            if (transactionToDelete != null)
            {
                this.dbContext.Transactions.Remove(transactionToDelete);
                this.dbContext.SaveChanges();
            }
        }

        public IEnumerable<Transaction> GetIncomeTransactions()
        {
            return dbContext.Transactions.Where(i => i.TransactionType == Services.TransactionType.Income);
        }

        public IEnumerable<Transaction> GetExpensesTransactions()
        {
            return dbContext.Transactions.Where(i => i.TransactionType == Services.TransactionType.Expenses);

        }
    }
}
