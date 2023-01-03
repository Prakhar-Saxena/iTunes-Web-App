namespace ITunesWebApp.Models
{
    public class ClickMap
    {
        public ClickMap()
        {
            NameFrequencyMap = new Dictionary<string, int>();
        }
        public Dictionary<string, int> NameFrequencyMap { get; set; }
    }
}
