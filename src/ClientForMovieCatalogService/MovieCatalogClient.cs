using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientForMovieCatalogService
{
    public class MovieCatalogClient
    {
        private readonly HttpClient _httpClient;
        private readonly string backEndRootUrl;

        public MovieCatalogClient(HttpClient httpClient, string backEndRootUrl)
        {
            _httpClient = httpClient;
            this.backEndRootUrl = backEndRootUrl;
        }

        public async Task<ICollection<CatalogItem>> CatalogitemsAllAsync()
        {
            var jsonString = await _httpClient.GetStringAsync($"{backEndRootUrl}/catalogitems");
            return JsonConvert.DeserializeObject<List<CatalogItem>>(jsonString);
        }
    }
}
