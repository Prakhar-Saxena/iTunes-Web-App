using Microsoft.AspNetCore.Mvc;
using ITunesWebApp.Models;
using ITunesWebApp.Services;
using System.Text.Encodings.Web;

namespace ITunesWebApp.Controllers
{
    public class ITunesController : Controller
    {
        static Reader reader = new Reader();
        static ClickMap clickMap = new ClickMap();
        //
        // GET: /iTunes/
        public string Index()
        {
            //return View();
            return "iTunes Index.";
        }
        //
        // GET: /iTunes/Search
        // Requires using System.Text.Encodings.Web;
        public List<SearchItem> Search(string name)
        {
            if (name == null)
            {
                name = "Apple";
            }

            if (clickMap.NameFrequencyMap.ContainsKey(name))
            {
                clickMap.NameFrequencyMap[name] = clickMap.NameFrequencyMap[name] + 1;
            }
            else
            {
                clickMap.NameFrequencyMap[name] = 1;
            }

            return reader.QueryItunes(name);
            //return HtmlEncoder.Default.Encode($"Searching for {name}.");
            //https://localhost:7195/iTunes/Search?name=Apple
            //https://localhost:7195/iTunes/Search?name=ReachMobi
            //https://localhost:7195/iTunes/Search?name=Prakhar
            //https://localhost:7195/iTunes/Search?name=Prakhar\ Saxena
        }

        //
        // GET: /iTunes/Clicks
        public Dictionary<string, int> Clicks()
        {
            Console.WriteLine("Returning Search Frequency Map.");
            Console.WriteLine("Name Count: " + clickMap.NameFrequencyMap.Count);
            foreach (KeyValuePair<string, int> kv in clickMap.NameFrequencyMap)
            {
                Console.WriteLine(kv.Key + " => " + kv.Value);
            }
            return clickMap.NameFrequencyMap;
        }
        //https://localhost:7195/iTunes/Clicks
    }
}
