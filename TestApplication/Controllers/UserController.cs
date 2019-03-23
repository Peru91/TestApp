using App.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class UserController : ApiController
    {
        //[HttpGet]
        //public string Ping()
        //{
        //    return "Connection Successful";
        //}
        
        [HttpGet]
        [ApiExceptionFilter]
        public void CheckAuthorization()
        {
            throw new Exception();
        }

    }
}
