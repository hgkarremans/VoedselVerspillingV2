using Microsoft.AspNetCore.Mvc;
using VoedselStore.Domain.Services;
using VoedselStore.Infrastructure.ContextClasses;
using VoedselVerspilling.Domain.Services;

namespace VoedselStore.Controllers
{
    public class MealBoxController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICanteenRepository _canteenRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMealBoxRepository _mealboxRepository;

        public MealBoxController(IProductRepository productRepository, ICanteenRepository canteenRepository, 
            IEmployeeRepository employeeRepository, 
            IMealBoxRepository mealboxRepository)
        {
            _productRepository = productRepository;
            _canteenRepository = canteenRepository;
            _employeeRepository = employeeRepository;
            _mealboxRepository = mealboxRepository;
        }

        [HttpGet]
        public IActionResult Aanmaken()
        {
            var products = _productRepository.GetAll;
            ViewBag.Products = products;
            return View();
        }
    }
}
