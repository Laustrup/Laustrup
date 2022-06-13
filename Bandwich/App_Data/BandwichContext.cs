using Bandwich.entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App_Data
{
    public class BandwichContext : IdentityDbContext
    {
        public BandwichContext(DbContextOptions<BandwichContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            // This is where db entities can be seeded for test uses
            SeedBands(builder);
            SeedVenues(builder);
            SeedGigs(builder);
        }
        
        public DbSet<Band> Bands { get; set; }
        private void SeedBands(ModelBuilder builder)
        {
            
        }
        
        public DbSet<Venue> Venues { get; set; }
        private void SeedVenues(ModelBuilder builder)
        {
            
        }

        public DbSet<Gig> Gigs { get; set; }
        private void SeedGigs(ModelBuilder builder)
        {
            
        }
    }
}