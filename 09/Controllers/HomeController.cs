using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StationSite.Models;
using StationSite.Services;

namespace StationSite.Controllers
{
    public class HomeController : Controller
    {
        private IReadStations stationService;

        public HomeController(IReadStations nsService)
        {
            stationService = nsService;
        }

        public async Task<IActionResult> Index()
        {
            var stations = await stationService.ReadStations();
            var model = new IndexViewModel(){
                Stations = stations
            };
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
