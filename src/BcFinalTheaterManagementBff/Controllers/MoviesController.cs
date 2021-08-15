using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace BcFinalTheaterManagementBff.Controllers
{
    [ApiController]
    [Route("movies")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(ILogger<MoviesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            var movies = new Movie[]
            {
                new Movie(id: "tt0076759", title: "Star Wars: Episode IV - A New Hope"),
                new Movie(id: "tt0193524", title: "The Star Wars Holiday Special")
            };
            return movies.ToArray();
        }
    }
}
