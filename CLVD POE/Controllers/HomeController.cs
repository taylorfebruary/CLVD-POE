using CLVD_POE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CLVD_POE.Controllers
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
            return View();
        }

        public IActionResult AboutUs() 
        { 
            return View("AboutUs");
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult OurWork()
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
