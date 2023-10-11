    using Microsoft.AspNetCore.Mvc;
    using VoedselVerspilling.Domain.Services;
using Microsoft.AspNetCore.Http;

namespace VoedselVerspilling.Controllers
    {
        public class HomeController : Controller
        {
            private readonly IProductRepository repository;
            public HomeController(IProductRepository repo)
            {
                repository = repo;
            }

            public IActionResult Index()
            {
            if (User.Identity.IsAuthenticated)
            {
                Console.WriteLine("Logged in");
            }
            else
            {
                Console.WriteLine("Not logged in");
            }
            return View();
            }
        }
    }
