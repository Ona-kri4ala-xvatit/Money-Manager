using Money_Manager.Context;
using Money_Manager.Models;
using Money_Manager.Repositories.Base;

namespace Money_Manager.Repositories
{
    public class IncomeEFRepository : IIncomeRepository
    {
        private readonly MoneyManagerDbContext dbContext;
        public IncomeEFRepository(MoneyManagerDbContext moneyManagerDbContext) => this.dbContext = moneyManagerDbContext;


        public void CreateIncomeTransaction(Transaction transaction)
        {
            dbContext.Transactions.Add(transaction);
            dbContext.SaveChanges();
        }
    }
}
