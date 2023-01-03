using Microsoft.AspNetCore.Mvc;
using ITunesWebApp.Models;
using ITunesWebApp.Services;
using System.Text.Encodings.Web;

namespace ITunesWebApp.Controllers
{
    public class ITunesController : Controller
    {
        Reader reader = new Reader();
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
            return reader.QueryItunes(name);
            //return HtmlEncoder.Default.Encode($"Searching for {name}.");
            //https://localhost:7195/iTunes/Search?name=Apple
            //https://localhost:7195/iTunes/Search?name=ReachMobi
            //https://localhost:7195/iTunes/Search?name=Prakhar
            //https://localhost:7195/iTunes/Search?name=Prakhar\ Saxena
        }
    }
}
