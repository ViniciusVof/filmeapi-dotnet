using Microsoft.EntityFrameworkCore;
using webapi_dotnet.Models;

namespace webapi_dotnet.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opts)
            : base(opts)
        {

        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}