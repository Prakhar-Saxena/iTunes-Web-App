namespace ITunesWebApp.Models
{
    public class SearchItem
    {
        public string wrapperType { get; set; }
        public string kind { get; set; }
        public long artistId { get; set; }
        public long collectionId { get; set; }
        public long trackId { get; set; }
        public string artistName { get; set; }
        public string collectionName { get; set; }
        public string trackName { get; set; }
        public string collectionCensoredName { get; set; }
        public string trackCensoredName { get; set; }
        public string artistViewUrl { get; set; }
        public string collectionViewUrl { get; set; }
        public string trackViewUrl { get; set; }
        public string previewUrl { get; set; }
        public string artworkUrl30 { get; set; }
        public string artworkUrl60 { get; set; }
        public string artworkUrl100 { get; set; }
        public double collectionPrice { get; set; }
        public double trackPrice { get; set; }
        public double collectionHdPrice { get; set; }
        public double trackHdPrice { get; set; }
        public DateTime releaseDate { get; set; }
        public string collectionExplicitness { get; set; }
        public string trackExplicitness { get; set; }
        public int discCount { get; set; }
        public int discNumber { get; set; }
        public int trackCount { get; set; }
        public int trackNumber { get; set; }
        public long trackTimeMillis { get; set; }
        public string country { get; set; }
        public string currency { get; set; }
        public string primaryGenreName { get; set; }
        public string contentAdvisoryRating { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }

        public override string ToString() {
            string output = "";
            output += "wrapperType: " + wrapperType + "\n";
            output += "kind: " + kind + "\n";
            output += "artistId: " + artistId + "\n";
            output += "collectionId: " + collectionId + "\n";
            output += "trackId: " + trackId + "\n";
            output += "artistName: " + artistName + "\n";
            output += "collectionName: " + collectionName + "\n";
            output += "trackName: " + trackName + "\n";
            output += "collectionCensoredName: " + collectionCensoredName + "\n";
            output += "trackCensoredName: " + trackCensoredName + "\n";
            output += "artistViewUrl: " + artistViewUrl + "\n";
            output += "collectionViewUrl: " + collectionViewUrl + "\n";
            output += "trackViewUrl: " + trackViewUrl + "\n";
            output += "previewUrl: " + previewUrl + "\n";
            output += "artworkUrl30: " + artworkUrl30 + "\n";
            output += "artworkUrl60: " + artworkUrl60 + "\n";
            output += "artworkUrl100: " + artworkUrl100 + "\n";
            output += "collectionPrice: " + collectionPrice + "\n";
            output += "trackPrice: " + trackPrice + "\n";
            output += "collectionHdPrice: " + collectionHdPrice + "\n";
            output += "trackHdPrice: " + trackHdPrice + "\n";
            output += "releaseDate: " + releaseDate + "\n";
            output += "collectionExplicitness: " + collectionExplicitness + "\n";
            output += "trackExplicitness: " + trackExplicitness + "\n";
            output += "discCount: " + discCount + "\n";
            output += "discNumber: " + discNumber + "\n";
            output += "trackCount: " + trackCount + "\n";
            output += "trackNumber: " + trackNumber + "\n";
            output += "trackTimeMillis: " + trackTimeMillis + "\n";
            output += "country: " + country + "\n";
            output += "currency: " + currency + "\n";
            output += "primaryGenreName: " + primaryGenreName + "\n";
            output += "contentAdvisoryRating: " + contentAdvisoryRating + "\n";
            output += "shortDescription: " + shortDescription + "\n";
            output += "longDescription: " + longDescription + "\n";
            return output;
        }
    }
}
