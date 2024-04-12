using DTO;

namespace DAL
{
    public interface IAccountDB
    {
        int AddAmountByUID(string UID, double QuotaCHF);
        int AddAmountByUsername(string Username, double QuotaCHF);
        Account GetAccountByUID(string UID);
        Account GetAccountByUsername(string Username);
    }
}