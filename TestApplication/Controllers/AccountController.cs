using App.BAL.CRUDHandler;
using App.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestApplication.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        public UserTokenDetails Login([FromBody] User loginDetails)
        {
            // validate login credentials and then return token info.

            LoginHandler lh = new LoginHandler();
            if (lh.AutenticateUser(loginDetails)){
                // If Authentication is true then
               // generate token and return tokendetails
            }
            return new UserTokenDetails();
        }
    }
}
