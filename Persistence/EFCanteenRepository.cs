using VoedselStore.Domain.Services;
using VoedselStore.Infrastructure.ContextClasses;
using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Infrastructure
{
    public class EFCanteenRepository : ICanteenRepository
    {
        private readonly StoreDbContext context;

        public EFCanteenRepository(StoreDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Canteen> GetAll => context.Canteens;

    }
}
