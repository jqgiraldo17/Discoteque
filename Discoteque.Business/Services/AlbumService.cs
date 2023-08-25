using Discoteque.Business.IServices;
using Discoteque.Business.Utils;
using Discoteque.Data;
using Discoteque.Data.Models;
using System.Net;

namespace Discoteque.Business.Services;

public class AlbumService : IAlbumService
{
    private readonly IUnitOfWork _unitOfWork;
    public AlbumService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// Creates a new <see cref="Album"/> entity in Database. 
    /// </summary>
    /// <param name="album">A new album entity</param>
    /// <returns>The created album with an Id assigned</returns>
    public async Task<BaseMesagge<Album>> CreateAlbum(Album album)
    {
        var newAlbum = new Album()
        {
            Name = album.Name,
            ArtistId = album.ArtistId,
            Genre = album.Genre,
            Year = album.Year,
            Cost = album.Cost,
        };

        await _unitOfWork.AlbumRepository.AddAsync(newAlbum);
        await _unitOfWork.SaveAsync();  
        return newAlbum;
    }
    public async Task<Album> GetAlbumAsync(bool areReferencesLoaded)
    {
        IEnumerable<Album> albums;
        if 
    }
    public async Task<IEnumerable<Album>> GetAlbumByArtist(string artist)
    {}
    public async Task<IEnumerable<Album>> GetAlbumByGenre(Genres genre)
    {}
    public async Task<IEnumerable<Album>> GetAlbumByYear(int year)
    {}
    public async Task<IEnumerable<Album>> GetAlbumByYearRange(int initialYear, int maxYear)
    {}
    public async Task<Album> GetById(int id)
    {}
    public async Task<Album> UpdateAlbum(Album album)
    {}
}