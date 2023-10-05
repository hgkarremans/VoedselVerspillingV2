using VoedselStore.Domain.Services;
using VoedselStore.Infrastructure.ContextClasses;
using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Infrastructure
{
    public class EFMealBoxRepository : IMealBoxRepository
    {
        private readonly StoreDbContext context;

        public EFMealBoxRepository(StoreDbContext context)
        {
            this.context = context;
        }
        public IQueryable<MealBox> GetAll => context.Meals;
    }
}
