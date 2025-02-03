using System.Diagnostics;
using ASPMVC.Models;
using EmpMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpMVC.Controllers
{
    public class HomeController : Controller
    {
        List<Emp> empList;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            empList = new List<Emp>()
            {
                new Emp(){ Id=1 , Name="Amol"},
                new Emp(){ Id=2 , Name="Amol"},
                new Emp(){ Id=3 , Name="Amol"},
                new Emp(){ Id=4 , Name="Amol"},
                new Emp(){ Id=5 , Name="Amol"},
            };
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(empList);
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
