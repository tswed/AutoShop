using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DomainLayer.Data
{
    public class AutoShopDbContext : DbContext
    {
        public AutoShopDbContext(DbContextOptions<AutoShopDbContext> options) 
            : base(options)
        {
        }

        public DbSet<VehicleEF> Vehicles { get; set; }
        
        // Add other DbSets for your entities here
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Configure entity relationships and constraints here
            modelBuilder.Entity<VehicleEF>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.VIN).IsRequired().HasMaxLength(17);
                entity.HasIndex(e => e.VIN).IsUnique();
            });
        }
    }
}