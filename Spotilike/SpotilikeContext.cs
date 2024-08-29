using Microsoft.EntityFrameworkCore;
using Spotilike.Models;

namespace Spotilike
{
    public class SpotilikeContext : DbContext
    {
        public SpotilikeContext(DbContextOptions<SpotilikeContext> options)
       : base(options)
        {
        }

        public DbSet<Artiste> Artistes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Morceau> Morceaux { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
