using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _009_HandleExceptionWithFilters_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = "https://localhost:44310/api/";

            var client = new HttpClient();
            var response1 = client.GetAsync(address + "test/1").Result;
            Console.WriteLine(response1.StatusCode);

            Console.WriteLine();

            var response2 = client.GetAsync(address + "test/0").Result;
            Console.WriteLine(response2.StatusCode);


            Console.ReadLine();
        }
    }
}
