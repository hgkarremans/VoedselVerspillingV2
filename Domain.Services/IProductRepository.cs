using WebApplication1.Core.Domain.Model;

namespace VoedselVerspilling.Domain.Services
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAll { get; }



    }
}
