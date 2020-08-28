using _008WebAPIFilters.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _008WebAPIFilters.Controllers
{
    public class SchoolController : ApiController
    {
        [Logger1]
        public string Get()
        {
            return "Hello";
        }
    }
}
