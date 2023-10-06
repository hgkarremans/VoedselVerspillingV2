using Microsoft.AspNetCore.Mvc;
using VoedselStore.Models;

namespace VoedselStore.Controllers
{

    public class AccountController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                return View("Index", loginViewModel);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
