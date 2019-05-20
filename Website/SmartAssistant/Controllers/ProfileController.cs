using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SmartAssistant.Extentions;
using SmartAssistant.Models;
using SmartAssistant.ViewModels;

namespace SmartAssistant.Controllers
{
    public class ProfileController : Controller
    {
        UserManager<User> _userManager;
        IConfiguration _configuration;

        public ProfileController(IConfiguration configuration, UserManager<User> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            Task<User> u = _userManager.GetUserAsync(HttpContext.User);
            User user = await u;
            if (user == null)
            {
                return NotFound();
            }

            ProfileViewModel model = new ProfileViewModel { Id = user.Id, FirstName = user.FirstName, LastName = user.LastName, Email = user.Email, Year = user.Year, Phone = user.Phone };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.Email = model.Email;
                    user.UserName = user.Email;
                    user.Year = model.Year;
                    user.Phone = model.Phone;
                    if (model.Password != null)
                    {
                        await UpdatePassword(user, model.Password);
                    }

                    var result2 = await _userManager.UpdateAsync(user);
                    if (result2.Succeeded)
                    {
                        return RedirectToAction("Index").WithSuccess("Profile is updated!"); ;
                    }
                    else
                    {
                        foreach (var error in result2.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return View("Index");
        }

        protected async Task<bool> UpdatePassword(User user, string password)
        {
            var _passwordValidator =
               HttpContext.RequestServices.GetService(typeof(IPasswordValidator<User>)) as IPasswordValidator<User>;
            var _passwordHasher =
                HttpContext.RequestServices.GetService(typeof(IPasswordHasher<User>)) as IPasswordHasher<User>;
            IdentityResult result =
                    await _passwordValidator.ValidateAsync(_userManager, user, password);
            if (result.Succeeded)
            {
                user.PasswordHash = _passwordHasher.HashPassword(user, password);

                var result2 = await _userManager.UpdateAsync(user);
                return result2.Succeeded;
            }
            return false;
        }
    }
}