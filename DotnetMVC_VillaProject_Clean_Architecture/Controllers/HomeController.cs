using DotnetMVC_VillaProject_Clean_Architecture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotnetMVC_VillaProject_Clean_Architecture.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        
        public IActionResult Error()
        {
            return View(); 
        }
    }
}