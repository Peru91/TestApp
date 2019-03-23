using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace TestApplication.Models
{
    public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        
            public override void OnException(HttpActionExecutedContext context)
            {
            var exception = "sfsfsff";
                if (exception != null)
                {
                    context.Response = context.Request.CreateErrorResponse(HttpStatusCode.Forbidden, new HttpError("Invalid Key."));
                }
            }
        
    }
}