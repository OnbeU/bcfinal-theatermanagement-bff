﻿using BcFinalTheaterManagementBff.Clients.MovieCatalog;
using BcFinalTheaterManagementBff.Models;
using Microsoft.AspNetCore.Mvc;
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

        public MoviesController(ILogger<MoviesController> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IEnumerable<Movie>> GetAsync()
        {
            var client = new MovieCatalogClient(_httpClient);
            var catalogItems = await client.CatalogitemsAllAsync();

            return catalogItems
                .Select(ci => new Movie(ci.MovieMetadata.ImdbId, ci.MovieMetadata.Title))
                .ToList();

            // TODO: Add the following as instructions in the bootcamp materials,
            // then remove it.
            //var movies = new Movie[]
            //{
            //    new Movie(id: "tt0076759", title: "Star Wars: Episode IV - A New Hope"),
            //    new Movie(id: "tt0193524", title: "The Star Wars Holiday Special")
            //};
            //return movies.ToArray();
        }
    }
}
