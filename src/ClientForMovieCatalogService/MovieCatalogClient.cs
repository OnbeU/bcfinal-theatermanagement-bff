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
            var jsonString = await _httpClient.GetStringAsync("http://fakemoviecatalogsvc:80/catalogitems");
            return JsonConvert.DeserializeObject<List<CatalogItem>>(jsonString);
        }
    }
}
