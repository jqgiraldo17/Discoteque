using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.Business.Services;

public class ArtistService : IArtistService
{
    //private Random random = new Random();
  
    public async Task<Artist> CreateArtist(Artist artist)
    {
        return new Artist(){
            Id = 1,
            Name = "Master",
            Label = "EMI",
            IsOnTour = true
        };
    }

    public async Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        var list = new List<Artist>();

        list.Add(new Artist(){
            Id = Random.Shared.Next(0, 100),
            Name = "Master",
            Label = "EMI",
            IsOnTour = true
        });
        list.Add(new Artist(){
            Id = Random.Shared.Next(0, 100),
            Name = "Kelly Minogue",
            Label = "La papaya Records",
            IsOnTour = false
        });
        return list;
    }

    public Task<Artist> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }
}

