using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _001_MyFirstWebAPI_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstes Beispiel für Formating
            var adress = "https://localhost:44333/api/";

            HttpClient client = new HttpClient();

            var message1 = new HttpRequestMessage(HttpMethod.Get, adress + "MySecond");
            message1.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response1 = client.SendAsync(message1).Result;

            Console.WriteLine(response1.Content.ReadAsStringAsync().Result);
            Console.WriteLine();


            var message2 = new HttpRequestMessage(HttpMethod.Get, adress + "MySecond");
            message2.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

            var response2 = client.SendAsync(message2).Result;

            Console.WriteLine(response2.Content.ReadAsStringAsync().Result);
            Console.WriteLine();



            Console.ReadLine();

        }
    }
}
