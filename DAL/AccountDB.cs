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
            SqlConnection cn = null;

            try
            {
                cn = new SqlConnection(connectionString);
                cn.Open();

                string query = "UPDATE ACCOUNT SET AMOUNTCHF = @QuotaCHF, QUOTAFEUILLE = @quotaFeuilles WHERE USERNAME = @username";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@QuotaCHF", QuotaCHF);
                cmd.Parameters.AddWithValue("@quotaFeuilles", quotaFeuilles);
                cmd.Parameters.AddWithValue("@username", Username);

                result_NbrLignesAffectesByQuery = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - UPDATE ACCOUNT :");
                throw e;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }

            return result_NbrLignesAffectesByQuery;
        }

        public Account GetAccountByUID(int UID)
        {
            Account account = null;
            SqlConnection cn = null;

            try
            {
                cn = new SqlConnection(connectionString);
                cn.Open();

                string query = "SELECT * FROM ACCOUNT WHERE UID = @UID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@UID", UID);

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
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - GET ACCOUNT BY UID : ");
                throw e;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }

            return account;
        }

        public Account GetAccountByUsername(string Username)
        {
            Account account = null;
            SqlConnection cn = null;

            try
            {
                cn = new SqlConnection(connectionString);
                cn.Open();

                string query = "SELECT * FROM ACCOUNT WHERE USERNAME = @Username";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Username", Username);

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
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - GET ACCOUNT BY USERNAME : ");
                throw e;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }

            return account;
        }


        public Account AddAccount(string Username, int CardID)
        {
            Account account = null;
            SqlConnection cn = null;

            try
            {
                cn = new SqlConnection(connectionString);
                cn.Open();

                // Check if the username or cardID already exists
                string checkQuery = "SELECT COUNT(*) FROM ACCOUNT WHERE USERNAME = @Username OR CARDID = @CardID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, cn);
                checkCmd.Parameters.AddWithValue("@Username", Username);
                checkCmd.Parameters.AddWithValue("@CardID", CardID);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    // Username or cardID already exists, return empty Account with Username "AlreadyExists"
                    account = new Account();
                    account.Username = "AlreadyExists";
                    account.CardID = -1;
                }
                // Account doesn't exist yet, so INSERT it into the DB
                else
                {
                    // Username and cardID are unique, proceed with account creation
                    string insertQuery = "INSERT INTO ACCOUNT (CARDID, USERNAME, AMOUNTCHF, QUOTAFEUILLE) VALUES (@CardID, @Username, 0, 0); SELECT SCOPE_IDENTITY();";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, cn);
                    insertCmd.Parameters.AddWithValue("@CardID", CardID);
                    insertCmd.Parameters.AddWithValue("@Username", Username);

                    int newAccountId = Convert.ToInt32(insertCmd.ExecuteScalar());

                    // Fetch the newly inserted account
                    account = GetAccountByUID(newAccountId);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - ADD ACCOUNT : ");
                // Log the exception or handle it appropriately
                throw e;
            }
            finally
            {
                // Ensure the connection is closed even if an exception occurs
                if (cn != null)
                {
                    cn.Close();
                }
            }

            return account;
        }

    }
}
