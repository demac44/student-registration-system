using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using university.Models;

namespace university.Controllers
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
            ViewData["Id"] = Request.Cookies["id"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Append("id", "",
                new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}