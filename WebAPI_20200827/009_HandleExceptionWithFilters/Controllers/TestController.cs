using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _009_HandleExceptionWithFilters.Controllers
{
    public class TestController : ApiController
    {

        [ResourceRemoved]
        public HttpResponseMessage Get (int id)
        {
            if (id==0)
            {
                throw new ResourceRemovedException();
            }


            return Request.CreateResponse(HttpStatusCode.OK, id);
        }
    }
}
