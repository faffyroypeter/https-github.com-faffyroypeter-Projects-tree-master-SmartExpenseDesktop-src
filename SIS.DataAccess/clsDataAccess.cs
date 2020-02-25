using System;
using System.Data;
using System.Data.SqlClient;

namespace SIS.DataAccess
{
    public class clsDataAccess
    {
        // Sql Express edition 
        string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void InsertStudent(string roleNo, string firstName, string lastName, string place)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);

                SqlCommand cmd;
              
                //SQL STMT
                const string sql = "INSERT INTO [dbo].[TblStudentInfo] (RoleNo,FirstName,LastName,City) VALUES (@ROLE_NO,@FIRST_NAME,@LAST_NAME,@CITY)";
                cmd = new SqlCommand(sql, con);

                //ADD PARAMS
                cmd.Parameters.AddWithValue("@ROLE_NO", roleNo);
                cmd.Parameters.AddWithValue("@FIRST_NAME", firstName);
                cmd.Parameters.AddWithValue("@LAST_NAME", lastName);
                cmd.Parameters.AddWithValue("@CITY", place);

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

        public DataTable FetchStudents()
        {
            SqlConnection con = new SqlConnection(conString);
            var commandText = "SELECT Id,RoleNo,FirstName,LastName,City FROM [dbo].[TblStudentInfo]";
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
