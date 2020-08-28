using _005_WiederholungFormatting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _005_WiederholungFormatting.Controllers
{
    public class BookController : ApiController
    {

        public IHttpActionResult GetBook(int id)
        {
            var book = new Book()
            {
                Id = id,
                Author = "Charles Dickens",
                Title = "Great Expectations",
                Price = 9.95M,
                PublicationDate = new DateTime(2014, 1, 20)
            };

            return Ok(book);
        }
    }
}
