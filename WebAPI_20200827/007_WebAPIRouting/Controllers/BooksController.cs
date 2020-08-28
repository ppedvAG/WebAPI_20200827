using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _007_WebAPIRouting.Controllers
{
    public class BooksController : ApiController
    {

        [Route("api/CSharp/Books")]
        public string Get ()
        {
            return "CSharp Book";
        }
    }
}
