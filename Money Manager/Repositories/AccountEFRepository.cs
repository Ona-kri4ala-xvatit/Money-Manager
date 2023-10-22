using Money_Manager.Context;
using Money_Manager.Models;
using Money_Manager.Repositories.Base;
using Money_Manager.Services;
using System.Collections.Generic;
using System.Linq;

namespace Money_Manager.Repositories
{
    public class AccountEFRepository : IAccountRepository
    {
        private readonly MoneyManagerDbContext dbContext;

        public AccountEFRepository(MoneyManagerDbContext moneyManagerDbContext)
        {
            if (dbContext is null)
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

        public void DeleteAccount(int accountId)
        {
            var accountToDelete = this.dbContext.Accounts.FirstOrDefault(x => x.Id == accountId);

            if (accountToDelete != null)
            {
                this.dbContext.Accounts.Remove(accountToDelete);
                this.dbContext.SaveChanges();
            }
        }

        public void UpdateAccountBalance(int id, decimal money, TransactionType transactionType)
        {
            var account = dbContext.Accounts.FirstOrDefault(a => a.Id == id);

            if (account is not null)
            {
                if (transactionType == TransactionType.Income)
                {
                    account.Balance += money;
                    dbContext.SaveChanges();
                }
                else
                {
                    account.Balance -= money;
                    dbContext.SaveChanges();
                }
            }
        }

        public void UpdateAccountAfterDeleteTransaction(int id, decimal money)
        {
            var account = dbContext.Accounts.FirstOrDefault(a => a.Id == id);
            //if (account is null)
            //{
                
            //}

            if (account is not null)
            {
                account.Balance -= money;
                dbContext.SaveChanges();
            }
        }
    }
}
