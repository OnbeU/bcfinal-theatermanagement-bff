using System;

namespace BcFinalTheaterManagementBff.Clients.MovieCatalog
{
    /// <summary>
    /// An item in our movie catalog.
    /// Retrieved from the movie catalog service.
    /// </summary>
    public class CatalogItem
    {
        public Guid Id { get; set; }

        /// <summary>
        /// The <see cref="MovieMetadata"/> for the catalog item.
        /// </summary>
        public MovieMetadata MovieMetadata { get; set; }
    }
}
