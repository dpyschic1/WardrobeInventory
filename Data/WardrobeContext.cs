using Microsoft.EntityFrameworkCore;
using WardrobeInventory.Entities;

namespace WardrobeInventory.Data
{
    public class WardrobeContext : DbContext
    {
        public DbSet<WardrobeItem> WardrobeItems { get; set; }
        public DbSet<WardrobeItemImage> WardrobeItemImages { get; set; }

        public string DbPath { get;}

        public WardrobeContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "wardrobe.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<WardrobeItem>()
                .HasKey(x => x.Id);
                
            builder.Entity<WardrobeItemImage>()
                .HasKey(x => x.Id);

            builder.Entity<WardrobeItem>()
                .HasOne(w => w.WardrobeItemImage)
                .WithOne(w => w.WardrobeItem)
                .HasForeignKey<WardrobeItemImage>(w => w.WardrobeId);
        }
        
    }
}