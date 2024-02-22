namespace CLED.Artic.Web.Components.Services;
using CLED.Artic.Web.Models;
using static CLED.Artic.Web.Models.GetArtworksResponse;

public class ArtworksService : IArtworksService
{

    private readonly HttpClient _httpClient;

    public ArtworksService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<IEnumerable<Artwork>> GetArtworks()
    {
        var response = await _httpClient.GetFromJsonAsync<GetArtworksResponse>("https://api.artic.edu/api/v1/artworks");

        if (response == null)
            return [];

        return response.Data;

    }


}
