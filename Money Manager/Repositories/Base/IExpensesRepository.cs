using Money_Manager.Models;
using System.Collections.Generic;

namespace Money_Manager.Repositories.Base
{
    public interface IExpensesRepository
    {
        public IEnumerable<Transaction> CreateExpensesTransaction(Transaction transaction);
    }
}
