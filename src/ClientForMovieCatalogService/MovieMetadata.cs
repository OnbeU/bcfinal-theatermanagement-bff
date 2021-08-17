using Newtonsoft.Json;

namespace ClientForMovieCatalogService
{
    /// <summary>
    /// The metadata for a movie in our movie catalog.
    /// A value object of the <see cref="CatalogItem"/>.
    /// </summary>
    public class MovieMetadata
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("imdbId")]
        public string ImdbId { get; set; }
    }
}
