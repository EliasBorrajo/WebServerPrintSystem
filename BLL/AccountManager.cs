using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountManager : IAccountManager
    {
        // ATTRIBUTS
        private IAccountDB AccountDB { get; }
        private ITransactionDB TransactionDB { get; }

        // CONSTRUCTOR
        public AccountManager()
        {
            AccountDB = new AccountDB();
            TransactionDB = new TransactionDB();
        }

        // METHODS
        public int AddAmountByUsername(string Username, double QuotaCHF, string Services, int AccountId)
        {
            TransactionDB.AddTransaction(AccountId, QuotaCHF, Services);

            return AccountDB.AddAmountByUsername( Username, QuotaCHF );
        }

        public int AddAmountByUID(string UID, double QuotaCHF, string Services, int AccountId)
        {
            TransactionDB.AddTransaction(AccountId, QuotaCHF, Services);

            return AccountDB.AddAmountByUID(UID, QuotaCHF);
        }

        public Account GetAccountByUID(string UID)
        {
            return AccountDB.GetAccountByUID(UID);
        }

        public Account GetAccountByUsername(string Username)
        {
            return AccountDB.GetAccountByUsername(Username);
        }

        public int AddTransaction(int AccountId, double TranAmount, string Services)
        {
            return TransactionDB.AddTransaction(AccountId, TranAmount, Services);
        }

        public List<Transaction> GetTransactions(int AccountId)
        {
            return TransactionDB.GetTransactions(AccountId);
        }

        public int NewQuotFeuille(double AccountAmount)
        {
            int QuotaFeuille = (int)(AccountAmount / 0.08);

            return QuotaFeuille;
        }
    }
}
