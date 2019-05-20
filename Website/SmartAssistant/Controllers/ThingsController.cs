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
    public class ThingsController : Controller
    {
        int idShopGlobal = -1;
        UserManager<User> _userManager;
        IConfiguration _configuration;

        public ThingsController(IConfiguration configuration, UserManager<User> userManager)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        private Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public IActionResult ShopThings(int idShop)
        {
            List<ThingViewModel> things;
            WebRequest request = WebRequest.Create(_configuration.GetValue<string>("BackendUrl") + "api/thing/" + idShop);
            request.Method = "Get";

            using (var s = request.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    things = JsonConvert.DeserializeObject<List<ThingViewModel>>(contributorsAsJson);
                }
            }

            ShopThingsViewModel model = new ShopThingsViewModel { idShop = idShop, things = things };
            idShopGlobal = idShop;
            return View("Index", model);
        }

        public IActionResult AddNewThing(int id)
        {
            ViewBag.idShop = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewThing(AddThingViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                var user = await GetCurrentUserAsync();
                var userId = user?.Id;

                WebRequest request = WebRequest.Create(_configuration.GetValue<string>("BackendUrl") + "api/thing/" + id + "/" + model.name + "/" + model.kind + "/" + model.price);
                request.Method = "Post";
                request.GetResponse();

                List<ThingViewModel> things;
                request = WebRequest.Create(_configuration.GetValue<string>("BackendUrl") + "api/thing/" + id);
                request.Method = "Get";

                using (var s = request.GetResponse().GetResponseStream())
                {
                    using (var sr = new StreamReader(s))
                    {
                        var contributorsAsJson = sr.ReadToEnd();
                        things = JsonConvert.DeserializeObject<List<ThingViewModel>>(contributorsAsJson);
                    }
                }

                ShopThingsViewModel shopThingsModel = new ShopThingsViewModel { idShop = id, things = things };

                return View("Index", shopThingsModel);
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id, int idThing)
        {
            WebRequest request = WebRequest.Create(_configuration.GetValue<string>("BackendUrl") + "api/thing/" + id + "/" + idThing);
            request.Method = "Delete";
            request.GetResponse();

            List<ThingViewModel> things;
            request = WebRequest.Create(_configuration.GetValue<string>("BackendUrl") + "api/thing/" + id);
            request.Method = "Get";

            using (var s = request.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    things = JsonConvert.DeserializeObject<List<ThingViewModel>>(contributorsAsJson);
                }
            }

            ShopThingsViewModel shopThingsModel = new ShopThingsViewModel { idShop = id, things = things };

            return View("Index", shopThingsModel);
        }
    }
}