using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace API_StudentCard
{
    public class ServiceAccount : IServiceAccount
    {
        private IAccountManager AccountManager { get; }

        // Constructeur
        public ServiceAccount()
        {
            AccountManager = new AccountManager( );
        }

        public Account AddAmountByUsername(string Username, double QuotaCHF, string Services)
        {
            // 1) Recuperer les informations de l'account, que l'on va vouloir retrouner
            Account account = AccountManager.GetAccountByUsername(Username);

            // 1.1) si compte null, on sort
            if (account == null)
            {
                return null;
            }

            // 2) Ajouter le montant shouaité à la DB voulue 
            int nbrLignesAffectes = AccountManager.AddAmountByUsername(Username, QuotaCHF, Services, account.AccountId);

            account.AccountAmount += QuotaCHF;

            // 3) Mettre a jour le nombre de feuilles imprimables
            account.NewQuotaFeuille = AccountManager.NewQuotFeuille(account.AccountAmount);

            // 4) Recuperer l'historique des transactions
            account.ListeTransac = AccountManager.GetTransactions(account.AccountId);

            // 5) Retourner l'objet Account, pour que l'application client affiche les données nécessaires à l'écran
            return account;
        }

        public Account AddAmountByUID(string UID, double QuotaCHF, string Services)
        {
            Account account = AccountManager.GetAccountByUID(UID);

            if (account == null)
            {
                return null;
            }
            
            int nbrLignesAffectes = AccountManager.AddAmountByUID(UID, QuotaCHF, Services, account.AccountId);

            account.AccountAmount += QuotaCHF;

            account.NewQuotaFeuille = AccountManager.NewQuotFeuille(account.AccountAmount);

            account.ListeTransac = AccountManager.GetTransactions(account.AccountId);

            return account;
        }
    }
}
