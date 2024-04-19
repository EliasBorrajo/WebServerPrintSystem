using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDB : IAccountDB
    {
        private string connectionString = null;

        public AccountDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ELMIJO"].ConnectionString;
        }

        public int UpdateAccountByUsername(string Username, double QuotaCHF, int quotaFeuilles)
        {
            int result_NbrLignesAffectesByQuery = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE ACCOUNT SET AMOUNTCHF = @QuotaCHF, QUOTAFEUILLE = @quotaFeuilles WHERE USERNAME = @username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@QuotaCHF", QuotaCHF);
                    cmd.Parameters.AddWithValue("@quotaFeuilles", quotaFeuilles);
                    cmd.Parameters.AddWithValue("@username", Username);

                    cn.Open();

                    result_NbrLignesAffectesByQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - UPDATE ACCOUNT :");
                throw e;
            }

            return result_NbrLignesAffectesByQuery;
        }

        public Account GetAccountByUID(int UID)
        {
            Account account = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM ACCOUNT WHERE UID = @UID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@UID", UID);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            account = new Account();

                            account.UiD = (int)dr["UID"];
                            account.CardID = (int)dr["CARDID"];
                            account.Username = (string)dr["USERNAME"];
                            account.AccountAmount = (double)dr["AMOUNTCHF"];
                            account.QuotaFeuilles = (int)dr["QUOTAFEUILLE"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - GET ACCOUNT BY UID : ");
                throw e;
            }

            return account;
        }

        public Account GetAccountByUsername(string Username)
        {
            Account account = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM ACCOUNT WHERE USERNAME = @Username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Username", Username);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            account = new Account();

                            account.UiD = (int)dr["UID"];
                            account.CardID = (int)dr["CARDID"];
                            account.Username = (string)dr["USERNAME"];
                            account.AccountAmount = (double)dr["AMOUNTCHF"];
                            account.QuotaFeuilles = (int)dr["QUOTAFEUILLE"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - GET ACCOUNT BY USERNAME : ");
                throw e;
            }

            return account;
        }

        public Account AddAccount(string Username, int CardID)
        {
            Account account = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO ACCOUNT (CARDID, USERNAME, AMOUNTCHF, QUOTAFEUILLE) VALUES (@CardID, @Username, 0, 0); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@CardID", CardID);
                    cmd.Parameters.AddWithValue("@Username", Username);

                    cn.Open();
                    int newAccountId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Fetch the newly inserted account
                    account = GetAccountByUID(newAccountId);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - ADD ACCOUNT : ");
                throw e;
            }

            return account;
        }
    }
}
