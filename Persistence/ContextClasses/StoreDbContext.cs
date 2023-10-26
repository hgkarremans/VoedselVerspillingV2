
using Microsoft.EntityFrameworkCore;
using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Infrastructure.ContextClasses
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<MealBox> Meals => Set<MealBox>();
        public DbSet<Canteen> Canteens => Set<Canteen>();
        public DbSet<Student> Students => Set<Student>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var biertje = new Product
            {
                Name = "Biertje",
                ContainsAlcohol = true,
                Photo = "https://www.bierista.nl/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/r/brand_up_0_0.jpg"
            };
            var frikandel = new Product
            {
                Name = "Frikandel",
                ContainsAlcohol = false,
                Photo = "https://www.ah.nl.kpnis.nl/static/product/AHI_434d50303235303030_1_LowRes_JPG.JPG?options=399,q85"
            };
            var kroket = new Product
            {
                Name = "Kroket",
                ContainsAlcohol = false,
                Photo = "https://www.ah.nl.kpnis.nl/static/product/AHI_434d50303233303030_1_LowRes_JPG.JPG?options=399,q85"
            };
            var kaas = new Product
            {
                Name = "Kaas",
                ContainsAlcohol = false,
                Photo = "https://www.ah.nl.kpnis.nl/static/product/AHI_434d50303536303030_1_LowRes_JPG.JPG?options=399,q85"
            };
            modelBuilder.Entity<MealBox>()
            .HasMany(p => p.products)
            .WithMany(t => t.MealBoxes)
            .UsingEntity<Dictionary<string, object>>(
                "MealBoxProduct",
                r => r.HasOne<Product>().WithMany().HasForeignKey("ProductsId"),
                l => l.HasOne<MealBox>().WithMany().HasForeignKey("MealBoxesId"),
                je =>
                {
                    je.HasKey("ProductsId", "MealBoxesId");
                    je.HasData(
                        new { ProductsId = 7, MealBoxesId = 1 },
                        new { ProductsId = 7, MealBoxesId = 5 },
                        new { ProductsId = 1, MealBoxesId = 2 },
                        new { ProductsId = 2, MealBoxesId = 2 },
                        new { ProductsId = 5, MealBoxesId = 2 },
                        new { ProductsId = 6, MealBoxesId = 2 },
                        new { ProductsId = 2, MealBoxesId = 6 },
                        new { ProductsId = 1, MealBoxesId = 5 },
                        new { ProductsId = 3, MealBoxesId = 5 },
                        new { ProductsId = 3, MealBoxesId = 4 });
                });

            // Save the changes to the database
            base.OnModelCreating(modelBuilder);
        }
    }
}
