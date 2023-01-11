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
        /*public string Index()
        {
            //return View();
            return "iTunes Index.";
        }*/
        public ViewResult Index() //: /Views/ITunes/Index.cshtml, /Views/Shared/Index.cshtml, /Pages/Shared/Index.cshtml
        {
            return View();
            //return "iTunes Index.";
        }
        //
        // GET: /iTunes/Search
        // Requires using System.Text.Encodings.Web;
        public ViewResult Search(string name)
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

            return View(reader.QueryItunes(name));
            //return HtmlEncoder.Default.Encode($"Searching for {name}.");
            //https://localhost:7195/iTunes/Search?name=Apple
            //https://localhost:7195/iTunes/Search?name=ReachMobi
            //https://localhost:7195/iTunes/Search?name=Prakhar
            //https://localhost:7195/iTunes/Search?name=Prakhar\ Saxena
        }

        //
        // GET: /iTunes/Clicks
        public ViewResult Clicks()
        {
            Console.WriteLine("Returning Search Frequency Map.");
            Console.WriteLine("Name Count: " + clickMap.NameFrequencyMap.Count);
            foreach (KeyValuePair<string, int> kv in clickMap.NameFrequencyMap)
            {
                Console.WriteLine(kv.Key + " => " + kv.Value);
            }
            return View(clickMap.NameFrequencyMap);
        }
        //https://localhost:7195/iTunes/Clicks
    }
}
