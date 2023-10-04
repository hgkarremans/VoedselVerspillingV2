using VoedselStore.Domain.Modals;
using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Infrastructure
{
    public class EFCanteenRepository
    {
        private readonly StoreDbContext context;

        public EFCanteenRepository(StoreDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Canteen> GetAll() => context.Canteens;
    }
}
