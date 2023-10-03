using System.Collections.Concurrent;
using VoedselVerspilling.Domain.Services;
using WebApplication1.Core.Domain.Model;

namespace VoedselVerspilling.Infrastructure
{
    public class EFProductRepository : IProductRepository { 
        private readonly List<Product> products;

        public EFProductRepository(List<Product> products)
        {
            this.products = new List<Product>
            {
                new Product {Id = 1, ContainsAlcohol= true, Name = "Appel", Photo= "Yeet"},
                new Product {Id = 2, ContainsAlcohol= true, Name = "Banaan", Photo= "Yeet"},
            };
        }

        public void Add(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
        }

        public IQueryable<Product> GetAll()
        {
            return products.AsQueryable();
        }

        public Product GetById(int Id)
        {
            return products.Find(p => p.Id == Id);  
            
        }
    }
}
