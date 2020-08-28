using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace _009_HandleExceptionWithFilters
{
    public class ResourceRemovedAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is ResourceRemovedException)
            {
                actionExecutedContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Gone);
            }
        }
    }
}