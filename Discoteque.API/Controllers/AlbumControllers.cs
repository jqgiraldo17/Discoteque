using System.Data.SqlTypes;
using Discoteque.Business.IServices;
using Discoteque.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Discoteque.API.Controllers

[Route("api/[controller]")]
[ApiController]

public class AlbumController : ControllerBase
{
    private readonly IAlbumService _albumService;
}