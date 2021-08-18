using BcFinalTheaterManagementBff.Models;
using ClientForMovieCatalogService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BcFinalTheaterManagementBff.Controllers
{
    [ApiController]
    [Route("movies")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration configuration;

        public MoviesController(ILogger<MoviesController> logger, HttpClient httpClient, IConfiguration configuration)
        {
            _logger = logger;
            _httpClient = httpClient;
            this.configuration = configuration;
        }

        [HttpGet]
        public async Task<IEnumerable<Movie>> GetAsync()
        {
            var client = new MovieCatalogClient(_httpClient, configuration.GetSection("ServicesUrl:MovieCatalogService").Value);
            var catalogItems = await client.CatalogitemsAllAsync();

            return catalogItems
                .Select(ci => new Movie(ci.MovieMetadata.ImdbId, ci.MovieMetadata.Title))
                .ToList();
        }
    }
}
