
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using _008WebAPIFilters.Filters;

namespace _008WebAPIFilters.Controllers
{
    [Logger]
    public class StudentController : ApiController
    {
        
        public string Get()
        {
            return "Hello";
        }

        public string Get(int id)
        {
            return "Hello with ID";
        }
    }
}
