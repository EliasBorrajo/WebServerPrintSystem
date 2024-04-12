using DTO;
using System.Collections.Generic;

namespace BLL
{
    public interface IAccountManager
    {
        int AddAmountByUID(string UID, double QuotaCHF, string Services, int AccountId);
        int AddAmountByUsername(string Username, double QuotaCHF, string Services, int AccountId);
        int AddTransaction(int AccountId, double TranAmount, string Services);
        List<Transaction> GetTransactions(int AccountId);
        Account GetAccountByUID(string UID);
        Account GetAccountByUsername(string Username);
        int NewQuotFeuille(double AccountAmount);
    }
}