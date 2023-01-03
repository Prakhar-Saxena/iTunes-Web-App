namespace ITunesWebApp.Models
{
    public class SearchResponseList
    {
        public SearchResponseList() {
            resultCount = 0;
            results = new List<SearchItem>();
        }
        public int resultCount { get; set; }
        public List<SearchItem>? results { get; set; }

        internal int getResultCount()
        {
            return resultCount;
        }

        internal List<SearchItem> getResults()
        {
            return results;
        }
    }
}
