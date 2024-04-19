using DTO;
using System.Collections.Generic;

namespace BLL
{
    public interface IAccountManager
    {
        int UpdateAccountByUsername(string Username, double QuotaCHF, int QuotaFeuilles);
        int DimAmountByUsername(string Username, double QuotaCHF, int QuotaFeuilles);

        Account GetAccountByUID(int UID);
        Account GetAccountByUsername(string Username);

        int NewQuotFeuille(double AccountAmount);
        double NewAmountFromQuotaFeuilles(int quotaFeuilles);

        Account AddUser(string username, int cardID);
    }
}