using System;
using System.Data;
using System.Data.SqlClient;

namespace SIS.DataAccess
{
    public class clsDataAccess
    {
        // Sql Express edition 
        string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SmartExpenseTracker;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void InsertUser(string name, string userName, string email, string password)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);

                SqlCommand cmd;
              
                //SQL STMT
                const string sql = "INSERT INTO [dbo].[TblUsers] ([Name],UserName,Email,[Password]) VALUES (@NAME,@USER_NAME,@EMAIL,@PASSWORD)";
                cmd = new SqlCommand(sql, con);

                //ADD PARAMS
                cmd.Parameters.AddWithValue("@NAME", name);
                cmd.Parameters.AddWithValue("@USER_NAME", userName);
                cmd.Parameters.AddWithValue("@EMAIL", email);
                cmd.Parameters.AddWithValue("@PASSWORD", password);

                //OPEN CON AND EXEC INSERT
                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        // Success
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                var exceptionDetail = ex.InnerException;
            }
        }

        public DataTable FetchUsers()
        {
            SqlConnection con = new SqlConnection(conString);
            var commandText = "SELECT [name],UserName,Email,[Password] FROM [dbo].[TblUsers]";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandText, con);

            // Create DataSet which acts like a container to the query result executed from sql server
            DataSet ds = new DataSet();

            // Fill the results to first table of the dataset (data set can have more than one table like database)
            sqlDataAdapter.Fill(ds);

            // Return the first table ( obviously we have executed only a single query here)
            return ds.Tables[0];
        }
    }
}
