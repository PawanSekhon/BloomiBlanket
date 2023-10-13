using Microsoft.EntityFrameworkCore;
using BloomiBlanket.Models;

namespace BloomiBlanket.Data
{
    public class BloomiBlanketContext : DbContext
    {
        public BloomiBlanketContext(DbContextOptions<BloomiBlanketContext> options)
            : base(options)
        {
        }

        public DbSet<Blanket> Blanket { get; set; }
    }
}