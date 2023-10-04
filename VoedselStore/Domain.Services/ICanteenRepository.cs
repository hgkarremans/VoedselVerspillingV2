using WebApplication1.Core.Domain.Model;

namespace VoedselStore.Domain.Services
{
    public interface ICanteenRepository
    {
        IQueryable<Canteen> GetAll { get; }
    }
}
