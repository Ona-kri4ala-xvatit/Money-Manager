using Money_Manager.Context;
using Money_Manager.Models;
using Money_Manager.Services;
using System.Collections.Generic;

namespace Money_Manager.Repositories.Base
{
    public interface IAccountRepository
    {
        public IEnumerable<Account> GetAllAccounts();
        public void CreateAccount(Account account);
        public void DeleteAccount(int accountId);
        public void UpdateAccountBalance(int id, decimal money, TransactionType transactionType);
    }
}
