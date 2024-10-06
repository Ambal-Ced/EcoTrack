using EcoTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoTrack.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }
        public DbSet<info> info { get; set; }
        public DbSet<electrates> electrates { get; set; }
        public DbSet<insights> insights { get; set; }
        public DbSet<waterrates> waterrates { get; set; }
        public DbSet<pfeed> pfeed { get; set; }
        public DbSet<ppost> ppost { get; set; }

    }
}
