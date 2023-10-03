using Microsoft.AspNetCore.Mvc;
using VoedselVerspilling.Domain.Services;

namespace VoedselVerspilling.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        /*public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }*/
        public IActionResult Index()
        {
            return View();
        }
    }
}
