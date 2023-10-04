using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Domain.Modals
{
    public class StoreDbContext : DbContext 
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Products => Set<Product>();
    }
}
