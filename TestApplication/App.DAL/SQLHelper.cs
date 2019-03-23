using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace App.DAL
{
    public static class SQLDataAccessHelper
    {
      static  string  connectionString = string.Empty;

         static SQLDataAccessHelper()
        {
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

            }
            catch (Exception)
            {
                //todo error handling  mechanism
                throw;
            }
        }



        public static void ExecuteNonQuery(string commandText, CommandType commandType, params SqlParameter[] commandParameters)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(commandText, connection))
            {
                command.CommandType = commandType;
                command.Parameters.AddRange(commandParameters);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static DataSet ExecuteQuery(SqlCommand cmd)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                connection.Close();
                return ds;
            }
        }
    }
}
