using DockerPractiseProjSimpliLearn.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DockerPractiseProjSimpliLearn.Controllers
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
        [HttpPost]
        public IActionResult Index(IFormCollection c)
        {
            string usrname = c["username"].ToString();
            string psswd = c["password"].ToString();
            if (usrname == "d4rshsh" && psswd == "boots1005")
            {
                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                ViewBag.Message1 = "Invalid Credentials..Try Again";
                return View();
            }
        }
        public IActionResult Dashboard()
        {
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