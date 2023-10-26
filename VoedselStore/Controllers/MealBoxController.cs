using Microsoft.AspNetCore.Mvc;
using VoedselVerspilling.Domain.Services;

namespace VoedselStore.Controllers
{
    public class MealBoxController : Controller
    {
        private readonly IProductRepository repository;

        public MealBoxController(IProductRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult Aanmaken()
        {
            return View();
        }
    }
}
