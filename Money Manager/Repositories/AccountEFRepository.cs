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

        public AccountEFRepository(MoneyManagerDbContext moneyManagerDbContext) 
        { 
            if(dbContext is null)
                this.dbContext = new MoneyManagerDbContext();
            else
                this.dbContext = moneyManagerDbContext; 
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return dbContext.Accounts.ToList();
        }

        public void CreateAccount(Account account)
        {
            dbContext.Accounts.Add(account);
            dbContext.SaveChanges();
        }
    }
}
