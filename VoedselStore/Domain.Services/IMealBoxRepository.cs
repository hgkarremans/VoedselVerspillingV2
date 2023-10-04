using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Domain.Services
{
    public interface IMealBoxRepository
    {
        IQueryable<MealBox> mealBoxes { get; }
    }
}
