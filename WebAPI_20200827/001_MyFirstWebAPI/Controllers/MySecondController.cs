using _001_MyFirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace _001_MyFirstWebAPI.Controllers
{
    public class MySecondController : ApiController
    {
        //public List<Person> GetPerson ()
        //{
        //    return new List<Person>
        //    {
        //        new Person { Id=1, Firstname="Muster", Lastname="Mustermann"},
        //        new Person { Id=2, Firstname="Muster", Lastname="Musterfrau"}
        //    };

        //}


        public IEnumerable<string> Get()
        {
            //IList<string> formatters = new List<string>();
            //GlobalConfiguration.Configuration.Formatters.Select(s=>


            foreach (var item in GlobalConfiguration.Configuration.Formatters)
            {
                //formatters.Add(item.ToString());

                yield return item.ToString();
            }



            //return formatters;
        }
    }
}
