using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _005_WiederholungFormatting_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44389/");

                // Set the Accept header for BSON.
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/bson"));

                //Send GET request
                // Send GET request.
                Task<HttpResponseMessage> result = client.GetAsync("api/book/1");
                result.Result.EnsureSuccessStatusCode();

                // Use BSON formatter to deserialize the result.
                MediaTypeFormatter[] formatters = new MediaTypeFormatter[] {
                    new BsonMediaTypeFormatter()
                };

                var book = result.Result.Content.ReadAsAsync<Book>(formatters).Result;
            }
        }
    }
}
