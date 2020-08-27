using _002_Formating_Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebApiContrib.Formatting;

namespace _002_Formating_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstes Beispiel für Formating
            

            //HttpClient client = new HttpClient();

            //var message1 = new HttpRequestMessage(HttpMethod.Get, adress + "First");
            //message1.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-protobuf"));

            //var response1 = client.SendAsync(message1).Result;

            //var deserialized = response1.Content.ReadAsAsync<IEnumerable<Person>>(new[] { new ProtoBufFormatter() }).Result;

            //foreach (var person in deserialized)
            //{
            //    Console.WriteLine($"{person.Id} {person.Firstname} {person.Lastname}");
            //}


            var address = "http://localhost:44354/api/";
            var client = new HttpClient();

            var meesage = new HttpRequestMessage(HttpMethod.Get, address + "First");
            meesage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-protobuf"));
            var response = client.SendAsync(meesage).Result;

            var deserialized = response.Content.ReadAsAsync<IEnumerable<Person>>(new[] { new ProtoBufFormatter() }).Result;

            foreach (var item in deserialized)
            {
                
            }




            Console.ReadLine();
        }
    }
}
