using Microsoft.AspNetCore.Mvc;
using VoedselVerspilling.Domain.Services;

namespace VoedselVerspilling.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository repository;
        public HomeController (IProductRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.GetAll);
        }
    }
}
