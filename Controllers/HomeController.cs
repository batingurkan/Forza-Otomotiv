using System.Diagnostics;
using Forza_Otomotiv.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forza_Otomotiv.Controllers
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
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Hakkımızda()
        {
            return View();
        }

        public IActionResult Tedarikcilerimiz()
            {
                return View();
            }
        public IActionResult İletisim()
            {
                return View();
            }
        public IActionResult Bayibasvuru()
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