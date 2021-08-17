using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientForMovieCatalogService
{
    public class MovieCatalogClient
    {
        private readonly HttpClient _httpClient;

        public MovieCatalogClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ICollection<CatalogItem>> CatalogitemsAllAsync()
        {
            // TODO: Don't hard-code this URL.
            var jsonString = await _httpClient.GetStringAsync("http://bcfinalmoviecatalogsvc:80/catalogitems");
            return JsonConvert.DeserializeObject<List<CatalogItem>>(jsonString);
        }
    }
}
