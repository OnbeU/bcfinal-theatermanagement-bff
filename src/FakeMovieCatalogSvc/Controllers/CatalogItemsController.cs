using ClientForMovieCatalogService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FakeMovieCatalogSvc.Controllers
{
    [Route("catalogitems")]
    [ApiController]
    public class CatalogItemsController : ControllerBase
    {
        // GET: api/CatalogItems
        [HttpGet]
        public IEnumerable<CatalogItem> GetCatalogItem()
        {
            List<CatalogItem> catalogItems = new List<CatalogItem>() {
                new CatalogItem() { Id = Guid.NewGuid(), 
                    MovieMetadata = new MovieMetadata() { ImdbId = "tt2488496", Title = "Star Wars: Episode VII - The Force Awakens" } },
                new CatalogItem() { Id = Guid.NewGuid(), 
                    MovieMetadata = new MovieMetadata() { ImdbId = "tt2527336", Title = "Star Wars: Episode VIII - The Last Jedi" } },
                new CatalogItem() { Id = Guid.NewGuid(), 
                    MovieMetadata = new MovieMetadata() { ImdbId = "tt2527338", Title = "Star Wars: Episode IX - The Rise of Skywalker" } }
            };
            return catalogItems.ToArray();
        }
    }
}
