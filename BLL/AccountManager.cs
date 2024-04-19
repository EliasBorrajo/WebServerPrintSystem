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

        // CONSTRUCTOR
        public AccountManager()
        {
            AccountDB = new AccountDB();
        }

        // METHODS
        public int UpdateAccountByUsername(string Username, double QuotaCHF, int QuotaFeuilles)
        {
            return AccountDB.UpdateAccountByUsername( Username, QuotaCHF, QuotaFeuilles );
        }

        public int DimAmountByUsername(string Username, double QuotaCHF, int QuotaFeuilles)
        {
            return AccountDB.UpdateAccountByUsername(Username, QuotaCHF, QuotaFeuilles);
        }

        public Account GetAccountByUID(int UID)
        {
            return AccountDB.GetAccountByUID(UID);
        }

        public Account GetAccountByUsername(string Username)
        {
            return AccountDB.GetAccountByUsername(Username);
        }

        public int NewQuotFeuille(double AccountAmount)
        {
            int QuotaFeuille = (int)(AccountAmount / 0.08);
            return QuotaFeuille;
        }

        public double NewAmountFromQuotaFeuilles(int quotaFeuilles)
        {
            double AccountAmount = quotaFeuilles * 0.08;
            return AccountAmount;
        }

        public Account AddUser(string username, int cardID)
        {
            return AccountDB.AddAccount(username, cardID);
        }
    }
}
