using App.DAL;
using App.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BAL.CRUDHandler
{
    public class LoginHandler
    {
        public bool AutenticateUser(User loginDetails) {           
                try
                {
                // 
               
                DataSet ds = null;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Action";
                param.Value = "Authenticate";

                SqlParameter param1 = new SqlParameter();
                param.ParameterName = "@Email";
                param.Value = loginDetails.Email;

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(param);
                cmd.Parameters.Add(param1);
                cmd.CommandText = "USP_User_ALL_OperationsAPI";
                cmd.CommandType = CommandType.StoredProcedure;

                ds = SQLDataAccessHelper.ExecuteQuery(cmd);
                    if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                    {
                    // perform your logic based on that return data.
                    return true;
                     
                    }
                
                
                }
                catch (Exception ex)
                {
                   
                }
            return false;
            }
        
    }
}
