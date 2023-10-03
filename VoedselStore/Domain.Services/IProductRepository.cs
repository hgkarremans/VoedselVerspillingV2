using WebApplication1.Core.Domain.Model;

namespace VoedselVerspilling.Domain.Services
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAll();
        Product GetById(int Id);
        void Add (Product product);


    }
}
