using Microsoft.EntityFrameworkCore;
using Discoteque.Data.Models;
namespace Discoteque.Data;

public class DiscotequeContext : DbContext
{
    //Vamos a hacer un constructor que indica en donde va a buscarse la data
    // Estmos diciendo con el base, que se herede todo desde EntityFrameworks: Es la configuración de la base de datos (DbContext)
    public DiscotequeContext(DbContextOptions<DiscotequeContext> options): base(options)
    {
    }
    //Ahora vamos a crear la base de datos
    //<Definicion de la base de datos> elementos que la componen
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }
}