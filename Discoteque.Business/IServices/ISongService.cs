using System;
using Discoteque.Data.Models;

namespace Discoteque.Business.IServices;

public interface ISongService
{
    Task<IEnumerable<Song>> GetSongAsync();
    Task<IEnumerable<Song>> GetSongsByAlbum(int AlbumId);
    Task<IEnumerable<Song>> GetSongsByYear(int year);
    Task<Song> GetById(int id);
    Task<BaseMessage<Song>> CreateSong(Song Song);
    Task<BaseMessage<Song>> CreateSongsInBatch(List<Song> songs);
    Task<Song> UpdateSong(Song song);
}