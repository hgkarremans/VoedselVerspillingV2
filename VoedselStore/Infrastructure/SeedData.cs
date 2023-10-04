using Microsoft.EntityFrameworkCore;
using VoedselStore.Domain.Modals;
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
                    new Product {  ContainsAlcohol = false, Name = "Tomato", Photo = "yeet" },
                    new Product {ContainsAlcohol= false, Name = "Apple", Photo= "yeet"}
                );

                context.SaveChanges();
            }
        }
    }
}
