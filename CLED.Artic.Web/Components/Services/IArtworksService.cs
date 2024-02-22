using CLED.Artic.Web.Models;

namespace CLED.Artic.Web.Components.Services
{
    public interface IArtworksService
    {
        Task<IEnumerable<GetArtworksResponse.Artwork>> GetArtworks();
    }
}