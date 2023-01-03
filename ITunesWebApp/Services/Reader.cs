using ITunesWebApp.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Microsoft.VisualBasic.FileIO;

namespace ITunesWebApp.Services
{
    public class Reader
    {
        private static string iTunesApiURL = "https://itunes.apple.com/search?term=";

        public List<SearchItem> QueryItunes(string name)
        {
            try
            {
                HttpClient client = new HttpClient(); // Not certain about defining it here
                string url = iTunesApiURL + name;
                Console.WriteLine(url);
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseTask = client.GetAsync(url);
                responseTask.Wait();
                var result = responseTask.Result;
                Console.WriteLine(result);
                SearchResponseList data;
                List<SearchItem> searchItems = new List<SearchItem>();
                if (result.IsSuccessStatusCode)
                {
                    var jsonData = result.Content.ReadAsStringAsync().Result;
                    data = JsonConvert.DeserializeObject<SearchResponseList>(jsonData);
                    Console.WriteLine("Result Count: " + data.getResultCount());
                    searchItems = data.getResults();
                    Console.WriteLine(" Search Items:");
                    foreach (SearchItem searchItem in searchItems)
                        Console.WriteLine(searchItem.ToString());
                }
                else
                {
                    //throw Exception;
                    data = new SearchResponseList();
                }
                return data.getResults();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong whilst fetching information from iTunes.");
                return new List<SearchItem>();
            }
            
        }
    }
}
