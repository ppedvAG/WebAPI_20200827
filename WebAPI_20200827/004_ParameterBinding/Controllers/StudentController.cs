using _004_ParameterBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _004_ParameterBinding.Controllers
{
    public class StudentController : ApiController
    {

        //https://www.tutorialsteacher.com/webapi/parameter-binding-in-web-api


        //public Student Get (int id)
        //{
        //    Student student = new Student(123, "Horst");

        //    return student;
        //}

        //public Student Get(int id, string name)
        //{
        //    Student student = new Student(123, "Horst");

        //    return student;
        //}

        public Student Get ([FromUri] Student student)
        {
            return new Student(1, "Timo");
        }

        

        //Wird nicht funktionieren!!!!
        //public HttpResponseMessage Post([FromBody] string name, [FromBody] int id)
        //{
        //    return new HttpResponseMessage(HttpStatusCode.OK);
        //}



        public Student Post([FromBody] string name, int id)
        {
            return new Student(1, "Timo");
        }








    }
}
