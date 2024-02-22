using CLED.Artic.Web.Models;
using static CLED.Artic.Web.Models.GetArtworksResponse;

namespace CLED.Artic.Web.Components.Services;

public class FakeArtworksService : IArtworksService
{
    public async Task<IEnumerable<Artwork>> GetArtworks()
    {
        var list = new List<Artwork>();
        for (int i = 0; i < 100; i++)
        {
            list.Add(new Artwork()
            {
                title = $"Titolo opera {i}",
                description = $"<p> Descrizione dell'opera {i} </p>"
            });
        }
        return await Task.FromResult(list);
    }
        
}
