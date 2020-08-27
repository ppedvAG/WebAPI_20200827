using _002_Formating.Models;
using _002_Formating_Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _002_Formating.Controllers
{
    public class FirstController : ApiController
    {
        public IEnumerable<Person> GetPerson()
        {
            return new List<Person>
            {
                new Person { Id=1, Firstname="Muster", Lastname="Mustermann"},
                new Person { Id=2, Firstname="Muster", Lastname="Musterfrau"}
            };

        }
    }
}
