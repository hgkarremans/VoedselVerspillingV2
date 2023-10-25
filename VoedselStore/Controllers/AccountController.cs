using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VoedselStore.Models;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace VoedselStore.Controllers
{


    public class AccountController : Controller
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };

                var res = await _userManager.CreateAsync(user, model.Password);
                if (res.Succeeded)
                {

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    if (!await _roleManager.RoleExistsAsync("Student"))
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Student"));
                    }
                    if (!await _roleManager.RoleExistsAsync("Employee"))
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Employee"));
                    }
                    if (model.UserRole == "Student")
                    {
                        await _userManager.AddToRoleAsync(user, "Student");
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(user, "Employee");
                    }
                    await _signInManager.SignOutAsync();
                    if ((await _signInManager.PasswordSignInAsync(user, model.Password, false, false)).Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

                foreach (var error in res.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If ModelState is not valid, return to the registration view with errors
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                var res = await _userManager.FindByEmailAsync(model.Email);
                if (res != null)
                {
                    await _signInManager.SignOutAsync();
                    if ((await _signInManager.PasswordSignInAsync(res, model.Password, false, false)).Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError("", "Invalid name or password");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()

        {
            return View();
        }
        [Authorize]
        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await _signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }

    }
}

