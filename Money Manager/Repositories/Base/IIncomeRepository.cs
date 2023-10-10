using Money_Manager.Models;

namespace Money_Manager.Repositories.Base
{
    public interface IIncomeRepository
    {
        public void CreateIncomeTransaction(Transaction transaction);
    }
}
