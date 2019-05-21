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
    public class CustomerListController : Controller
    {
        UserManager<User> _userManager;
        IConfiguration _configuration;

        public CustomerListController(IConfiguration configuration, UserManager<User> userManager)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        private Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            var userId = user?.Id;

            List<ThingViewModel> list;
            WebRequest request = WebRequest.Create(_configuration.GetValue<string>("BackendUrl") + "api/list/" + userId);
            request.Method = "Get";

            using (var s = request.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    list = JsonConvert.DeserializeObject<List<ThingViewModel>>(contributorsAsJson);
                }
            }

            ListInfoViewModel model = new ListInfoViewModel { userId = userId, things = list };
            return View(model);
        }

        public IActionResult AddNewItem() => View();

        [HttpPost]
        public async Task<IActionResult> AddNewItem(AddListItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await GetCurrentUserAsync();
                var userId = user?.Id;

                WebRequest request = WebRequest.Create(_configuration.GetValue<string>("BackendUrl") + "api/list/" + userId + "/" + model.name + "/" + model.kind);
                request.Method = "Post";
                request.GetResponse();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await GetCurrentUserAsync();
            var userId = user?.Id;

            WebRequest request = WebRequest.Create(_configuration.GetValue<string>("BackendUrl") + "api/list/" + id + "/" + userId);
            request.Method = "Delete";
            request.GetResponse();

            return RedirectToAction("Index");
        }
    }
}