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

        public Account AddAmountByUsername(string Username, double QuotaCHF)
        {
            // 1) Recuperer les informations de l'account, que l'on va vouloir retrouner
            Account account = AccountManager.GetAccountByUsername(Username);

            // 1.1) si compte null, on sort
            if (account == null)
            {
                return null;
            }

            // 4) Retourner l'objet Account, pour que l'application client affiche les données nécessaires à l'écran
            return AddAmount(account, QuotaCHF);

        }

        public Account AddAmountByUID(int UID, double QuotaCHF)
        {
            // 1) Recuperer les informations de l'account, que l'on va vouloir retrouner
            Account account = AccountManager.GetAccountByUID(UID);

            // 1.1) si compte null, on sort
            if (account == null)
            {
                return null;
            }

            // 4) Retourner l'objet Account, pour que l'application client affiche les données nécessaires à l'écran
            return AddAmount(account, QuotaCHF);
        }

        private Account AddAmount(Account account, double QuotaCHF)
        {
            // 1) Ajouter le montant shouaité à la DB voulue 
            account.AccountAmount += QuotaCHF;
            // 2) Re-Calculer le total de feuilles avec le nouveau total
            account.QuotaFeuilles = AccountManager.NewQuotFeuille(account.AccountAmount);

            // 3) Ajouter à la DB
            int nbrLignesAffectes = AccountManager.UpdateAccountByUsername(account.Username, 
                                                                       account.AccountAmount, 
                                                                       account.QuotaFeuilles);
            return account;
        }

        public Account dimAmount(string Username, int QuotaToPrint)
        {
            // 1) Recuperer les informations de l'account, que l'on va vouloir retrouner
            Account account = AccountManager.GetAccountByUsername(Username);

            // 1.1) si compte null, on sort
            if (account == null)
            {
                return null;
            }

            // 2) Supprimer le quota total du account
            account.QuotaFeuilles -= QuotaToPrint;

            // 3) Calculer le nouveau amount grâce à quota
            account.AccountAmount = AccountManager.NewAmountFromQuotaFeuilles(account.QuotaFeuilles);

            // 4) Update DB
            int nbrLignesAffectes = AccountManager.UpdateAccountByUsername( account.Username,
                                                                            account.AccountAmount,
                                                                            account.QuotaFeuilles);
    
            return account;
        }

        public Account AddUser(string Username, int CardID)
        {
            // 2) Envoyer à la DAL pour la DB le nouveau account
            Account account = AccountManager.AddUser(Username, CardID);

            // 3) Retourner le account crée dans la DB, avec TOUTES les infos de la DB
            return account;
        }

        
    }
}
