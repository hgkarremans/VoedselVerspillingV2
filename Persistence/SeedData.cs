using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VoedselStore.Infrastructure.ContextClasses;
using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Infrastructure
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "yeet",
                        ContainsAlcohol = true,
                        Photo = "https://www.ah.nl.kpnis.nl/static/product/AHI_434d50303536303031_1_LowRes_JPG.JPG?options=399,q85"
                    },
                    new Product
                    {
                        Name = "Bier",
                        ContainsAlcohol = true,
                        Photo = "https://www.bierista.nl/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/r/brand_up_0_0.jpg"
                    },
                    new Product
                    {
                        Name = "Frikandel",
                        ContainsAlcohol = false,
                        Photo = "https://www.ah.nl.kpnis.nl/static/product/AHI_434d50303235303030_1_LowRes_JPG.JPG?options=399,q85"
                    },
                    new Product
                    {
                        Name = "Kroket",
                        ContainsAlcohol = false,
                        Photo = "https://www.ah.nl.kpnis.nl/static/product/AHI_434d50303233303030_1_LowRes_JPG.JPG?options=399,q85"
                    },
                    new Product
                    {
                        Name = "Kaas",
                        ContainsAlcohol = false,
                        Photo = "https://www.ah.nl.kpnis.nl/static/product/AHI_434d50303536303030_1_LowRes_JPG.JPG?options=399,q85"
                    },
                    new Product
                    {
                        Name = "Wijn",
                        ContainsAlcohol = true,
                        Photo = "https://www.ah.nl.kpnis.nl/static/product/AHI_434d50303536303031_1_LowRes_JPG.JPG?options=399,q85"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
