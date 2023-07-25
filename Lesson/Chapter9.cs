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
        //More api at https://apipheny.io/free-api/

        static readonly string urlServerGet = "https://randomuser.me/api/";
        //static readonly string urlServerGet0 = "https://catfact.ninja/fact";
        
        //static readonly string urlServerGet = "https://postman-echo.com/get";
        static readonly string urlServerPost = "https://postman-echo.com/Post";
        static readonly string urlServerPut = "https://postman-echo.com/Put";
        static readonly string urlServerDelete = "https://postman-echo.com/delete";
        
        //static readonly string urlServerGet2 = "https://httpbin.org/get";//For get
        //static readonly string urlServerPost2 = "https://httpbin.org/post";//For post
        //static readonly string urlServerPut2 = "https://httpbin.org/put";//For post
        //static readonly string urlServerDelete2 = "https://httpbin.org/delete";//For post

        static readonly string resTxt = "E:/Temp/TestApiRes.txt";
                
        
        public static async Task Get()
        {
            string? apiUrl = urlServerGet;

            using HttpClient client = new();
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                ResponseConsoleLog(response);
            }
        }//Task Get()
                

        public static async Task Post()
        {
            string? apiUrl = urlServerPost;
            string jsonData = "{\"name\":\"John\",\"age\":30}";
            
            using HttpClient client = new();
            {
                StringContent contant = new(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl, contant);
                ResponseConsoleLog(response);
            }
        }//Task Post()
        
        public static async Task Put(string requestid)
        {
            string apiUrl = urlServerPut + "/" + requestid;
            string jsonData = "{\"name\":\"Johny\",\"age\":35}";
            
            using HttpClient client = new();
            {
                StringContent contant = new(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(apiUrl, contant);
                ResponseConsoleLog(response);
            }
        }//Task Put()

        public static async Task Delete(string requestid)
        {
            string apiUrl = urlServerDelete + "/" + requestid;
         
            using HttpClient client = new();
            {
                HttpResponseMessage response = await client.DeleteAsync(apiUrl);
                ResponseConsoleLog(response);
            }
        }//Task Delete()

        private static async void ResponseConsoleLog(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseData);
                using StreamWriter sw = new(resTxt);
                { await sw.WriteLineAsync(responseData); }
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }//Task ResponseConsoleLog()


    }//class Restful




}



