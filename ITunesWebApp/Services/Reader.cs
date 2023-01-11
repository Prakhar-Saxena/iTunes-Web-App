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
                HttpClient client = new HttpClient(); // Not certain about defining it here ; I don't think I can keep this static because I've to change the baseUrl everytime
                string url = iTunesApiURL + name;
                Console.WriteLine("Will attempt to make a call to: " + url);
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Console.WriteLine("Attempting to make a call to the iTunes API.");
                var responseTask = client.GetAsync(url);
                Console.WriteLine("Waiting on Response");
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
                Console.WriteLine("Something went wrong whilst fetching information from iTunes: " + e.Message);
                return new List<SearchItem>();
            }
            
        }
    }
}
