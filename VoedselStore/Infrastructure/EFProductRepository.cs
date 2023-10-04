using System.Collections.Concurrent;
using VoedselStore.Domain.Modals;
using VoedselVerspilling.Domain.Services;
using WebApplication1.Core.Domain.Model;

namespace VoedselVerspilling.Infrastructure
{
    public class EFProductRepository : IProductRepository { 
        private readonly StoreDbContext context;

        public EFProductRepository(StoreDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Product> GetAll => context.Products;


    }
}
