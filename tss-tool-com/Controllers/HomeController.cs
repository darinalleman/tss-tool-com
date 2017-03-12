using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dynastream.Fit;
using System.IO;

namespace WebApplication.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            FileStream fitSource = new FileStream("/home/darin/TSSTool/Assets/2017-02-17-19-07-46.fit", FileMode.Open);
            Console.WriteLine("File {0} is {1}", fitSource.Name, new Decode().CheckIntegrity(fitSource));

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
