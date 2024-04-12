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

        public int AddAmountByUsername(string Username, double QuotaCHF)
        {
            int result_NbrLignesAffectesByQuery = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE ACCOUNT SET ACCAMOUNT = ACCAMOUNT + @somme WHERE USERNAME = @username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@somme", QuotaCHF);
                    cmd.Parameters.AddWithValue("@username", Username);

                    cn.Open();

                    result_NbrLignesAffectesByQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - ADD AMOUNT :");
                throw e;
            }

            return result_NbrLignesAffectesByQuery;
        }

        public int AddAmountByUID(string UID, double QuotaCHF)
        {
            int result_NbrLignesAffectesByQuery = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE ACCOUNT SET ACCAMOUNT = ACCAMOUNT + @somme WHERE UID = @uid";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@somme", QuotaCHF);
                    cmd.Parameters.AddWithValue("@uid", UID);

                    cn.Open();

                    result_NbrLignesAffectesByQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - ADD AMOUNT :");
                throw e;
            }

            return result_NbrLignesAffectesByQuery;

        }

        public Account GetAccountByUID(string UID)
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

                            account.AccountId = (int)dr["ACCID"];
                            account.UID = (string)dr["UID"];
                            account.Username = (string)dr["USERNAME"];
                            account.AccountAmount = (double)dr["ACCAMOUNT"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - GET USERNAME : ");
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

                            account.AccountId = (int)dr["ACCID"];
                            account.UID = (string)dr["UID"];
                            account.Username = (string)dr["USERNAME"];
                            account.AccountAmount = (double)dr["ACCAMOUNT"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : ACCOUNT DB - GET USERNAME : ");
                throw e;
            }

            return account;
        }
    }
}
