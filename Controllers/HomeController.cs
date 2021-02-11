using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurants.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Restaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restList = new List<string>();

            foreach(Restaurants.Models.Restaurants r in Restaurants.Models.Restaurants.GetRestaurants())
            {
                restList.Add($"#{r.Rank}: Restaurant: {r.Rest} Recommended Dish: {r.Dish} Address: {r.Address} Phone: {r.Phone} Website:{r.Site}");
            }

            return View(restList);
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Restaurants.Models.Restaurants model)
        {
            if (ModelState.IsValid)
            {
                TempStorage.Form(model);
                return View("Confirmation", model);
            }
            else
            {
                return View();
            }
        }

        public IActionResult List()
        {
            foreach (Restaurants.Models.Restaurants r in TempStorage.Foods)
            { 
                if (r.Dish == null || r.Dish == "")
                {
                    r.Dish = "It's all tasty!";
                }
                if (r.Site == null || r.Site == "")
                {
                    r.Site = "Coming soon!";
                }
            }
            return View(TempStorage.Foods);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
