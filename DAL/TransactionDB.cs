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
    public class TransactionDB : ITransactionDB
    {
        private string connectionString = null;

        public TransactionDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ELMIJO"].ConnectionString;
        }

        public List<Transaction> GetTransactions(int AccountId)
        {
            List<Transaction> transactions = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [Transaction] WHERE AccId = @AccountId ORDER BY TranDateHour DESC;";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@AccountId", AccountId);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (transactions == null)
                                transactions = new List<Transaction>();

                            Transaction transaction = new Transaction();

                            if (dr["AccId"] != null)
                                transaction.AccountId = (int)dr["AccId"];

                            if (dr["TranDateHour"] != null)
                                transaction.TranDateHour = (DateTime)dr["TranDateHour"];

                            if (dr["TranAmount"] != null)
                                transaction.TranAmount = (double)dr["TranAmount"];

                            if (dr["Services"] != null)
                                transaction.Services = (string)dr["Services"];

                            transactions.Add(transaction);
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                throw se;
            }
            return transactions;
        }

        public int AddTransaction(int AccountId, double TranAmount, string Services)
        {
            int result = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO [Transaction](AccId, TranDateHour, TranAmount, Services) VALUES(@AccId, CONVERT(DATETIME2(0),SYSDATETIME()), @TranAmount, @Services);";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@Accid", AccountId);
                    cmd.Parameters.AddWithValue("@TranAmount", TranAmount);
                    cmd.Parameters.AddWithValue("@Services", Services);

                    cn.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException se)
            {
                throw se;
            }
            return result;
        }
    }

}