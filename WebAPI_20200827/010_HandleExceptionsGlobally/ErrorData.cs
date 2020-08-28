using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _010_HandleExceptionsGlobally
{
    public class ErrorData
    {
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
        public Uri RequestUri { get; set; }
        public Guid ErrorId { get; set; }
    }
}