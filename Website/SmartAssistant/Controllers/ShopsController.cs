using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SmartAssistant.Models;
using SmartAssistant.ViewModels;

namespace SmartAssistant.Controllers
{
    public class ShopsController : Controller
    {
        UserManager<User> _userManager;
        IConfiguration _configuration;

        public ShopsController(IConfiguration configuration, UserManager<User> userManager)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        private Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            var userId = user?.Id;

            List<ShopViewModel> shops;
            WebRequest request = WebRequest.Create(_configuration.GetValue<string>("BackendUrl") + "api/shop/" + userId);
            request.Method = "Get";

            using (var s = request.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    shops = JsonConvert.DeserializeObject<List<ShopViewModel>>(contributorsAsJson);
                }
            }

            ShopInfoViewModel model = new ShopInfoViewModel { userId = userId, shops = shops };
            return View(model);
        }

        public IActionResult AddShop() => View();

        [HttpPost]
        public async Task<IActionResult> AddShop(AddShopViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await GetCurrentUserAsync();
                var userId = user?.Id;

                WebRequest request = WebRequest.Create(_configuration.GetValue<string>("BackendUrl") + "api/shop/" + userId + "/" + model.name + "/" + model.latitude + "/" + model.longitude + "/" + model.area );
                request.Method = "Post";
                request.GetResponse();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteShop(int id)
        {
            WebRequest request = WebRequest.Create(_configuration.GetValue<string>("BackendUrl") + "api/shop/" + id);
            request.Method = "Delete";
            request.GetResponse();

            return RedirectToAction("Index");
        }
    }
}