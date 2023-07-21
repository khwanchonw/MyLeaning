using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Reflection.Metadata;

namespace Console1.Lesson
{
    public class Restful
    {
        //more request check https://sqa.stackexchange.com/questions/47097/free-sites-for-testing-post-rest-api-calls
        //static readonly string urlServer = "https://api.publicapis.org/entries"; //For get
        static readonly string urlServer = "https://httpbin.org/get";//For get
        //static readonly string urlServer = "https://httpbin.org/post";//For post
        
        //static readonly string urlServer = "https://catfact.ninja/fact";
        static readonly string resTxt = "E:/Temp/TestApiRes.txt";
               
        public static async Task Get()
        {
            string? apiUrl = urlServer;

            using HttpClient client = new();
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseData);

                    using StreamWriter sw =  new(resTxt);
                    {await sw.WriteLineAsync(responseData); }
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
        }//Task Main()

        public static async Task Post()
        {
            string? apiUrl = urlServer;
            using HttpClient client = new();
            string jsonData = "{\"name\":\"John\",\"age\":30}";
            StringContent contant = new (jsonData,Encoding.UTF8,"application/json");
            HttpResponseMessage respond = await client.PostAsync(apiUrl,contant);

            if (respond.IsSuccessStatusCode)
            {
                string respondData = await respond.Content.ReadAsStringAsync();
                Console.WriteLine(respondData);
            }
            else
            {
                Console.WriteLine($"Error: {respond.StatusCode} - {respond.ReasonPhrase}");
            }


        }

    }//class Restful
}



