    using Microsoft.AspNetCore.Mvc;
    using VoedselVerspilling.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace VoedselVerspilling.Controllers
    {
        public class HomeController : Controller
        {
            private readonly IProductRepository repository;
            private readonly UserManager<IdentityUser> _userManager;
            public HomeController(IProductRepository repo, UserManager<IdentityUser> userManager)
            {
                repository = repo;
            _userManager = userManager;
            }

            public IActionResult Index()
            {
            if (User.Identity.IsAuthenticated)
            {
                Console.WriteLine("Student: " + User.IsInRole("Student"));
                Console.WriteLine("Employee: " + User.IsInRole("Employee"));
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
