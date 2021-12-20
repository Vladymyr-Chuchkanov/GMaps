using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication0.Models;



namespace WebApplication0.Controllers
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
            var path = System.Environment.CurrentDirectory + "/wwwroot/res/Text1.txt";
            List<Person> persones = new List<Person>();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Person pers = new Person
                    {
                        GeoLat = Convert.ToDouble(line.Split('/')[0]),
                        GeoLong = Convert.ToDouble(line.Split('/')[1]),
                        Name = line.Split('/')[2],
                        Info = line.Split('/')[3],
                        Age = line.Split('/')[4],
                        FileName =  line.Split('/')[5]
                    };
                    persones.Add(pers);
                }
            }
                return View(persones);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Route()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult GetGeoCode()
        {
            

            return Json(new { geolat = 1, geolong = 2 });
        }
    }
}
