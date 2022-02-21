using ArtAPI.Models;

namespace ArtAPI.Services
{
  public class ArtistsService
  {
    internal List<Artist> GetAll()
    {
      return FakeDb.Artists;
    }

    internal Artist GetById(string artistId)
    {
      throw new NotImplementedException();
    }
  }
}