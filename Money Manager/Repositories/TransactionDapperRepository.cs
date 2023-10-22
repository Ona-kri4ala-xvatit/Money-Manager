using Dapper;
using Microsoft.Data.SqlClient;
using Money_Manager.Models;
using System.Collections.Generic;
using System.Linq;

namespace Money_Manager.Repositories
{
    public class TransactionDapperRepository
    {
        private const string connectionString = $"Server=localhost\\SQLEXPRESS;Database=MoneyManagerDb;TrustServerCertificate=True;Trusted_Connection=True;";
        //private const string connectionString = $"Server=localhost;Database=MoneyManagerDb;User Id=admin;Password=admin;"; 

        private readonly SqlConnection sqlConnection;

        public TransactionDapperRepository()
        {
            this.sqlConnection = new SqlConnection(connectionString);
            this.sqlConnection.Open();
        }

        public IEnumerable<Transaction> GetAllTransactionsToSave()
        {
            string sql = $"Select t.[Date], t.[Money], t.[TransactionType]  from Transactions t";
            return this.sqlConnection.Query<Transaction>(sql).ToList();
        }
    }
}
