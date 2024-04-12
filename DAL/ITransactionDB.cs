using DTO;
using System.Collections.Generic;

namespace DAL
{
    public interface ITransactionDB
    {
        int AddTransaction(int AccountId, double TranAmount, string Services);
        List<Transaction> GetTransactions(int AccountId);
    }
}