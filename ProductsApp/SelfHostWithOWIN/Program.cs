using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace SelfHostWithOWIN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var baseUrl = "http://localhost:1579/";

            using (WebApp.Start<Startup>(url: baseUrl))
            {
                HttpClient client = new HttpClient();
                var resp = client.GetAsync(baseUrl).Result;

                Console.WriteLine(resp);
                Console.WriteLine(resp.Content.ReadAsStringAsync().Result);

                Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
