using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _010_HandleExceptionsGlobally.Controllers
{
    public class TestController : ApiController
    {
        public HttpResponseMessage Get()
        {
            throw new Exception("Oooooooops!");
        }
    }
}
