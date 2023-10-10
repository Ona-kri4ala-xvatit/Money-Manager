using Money_Manager.Context;
using Money_Manager.Models;
using Money_Manager.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace Money_Manager.Repositories
{
    public class AccountEFRepository : IAccountRepository
    {
        private readonly MoneyManagerDbContext dbContext;

        //public AccountEFRepository() => dbContext = new MoneyManagerDbContext();
        public AccountEFRepository(MoneyManagerDbContext moneyManagerDbContext) => this.dbContext = moneyManagerDbContext;

        public IEnumerable<Account> GetAllAccounts()
        {
            return dbContext.Accounts.ToList();
        }
    }
}
