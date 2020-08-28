using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace _010_HandleExceptionsGlobally
{
    public class ContentNegotiatedExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            ErrorData metadata = new ErrorData
            {
                Message = "An unexpected error occurred! Please use the ticket ID to contact support",
                DateTime = DateTime.Now,
                RequestUri = context.Request.RequestUri,
                ErrorId = Guid.NewGuid()
            };

            // Hier können wir einen Logger verwendet, damit die Informationen auf WebAPI - Seite collektiert werden. 

            //log the metadata.ErrorId and the correlated Exception info to your DB/logs
            //or, if you have IExceptionLogger (chapter 8-3), it will already have been logged
            Debug.WriteLine("Error correlation id: {0}", metadata.ErrorId);

            HttpResponseMessage response = context.Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError, metadata);
            context.Result = new ResponseMessageResult(response);
        }
    }
}