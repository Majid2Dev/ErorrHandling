using ErorrHandling.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ErorrHandling.Controllers
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


        [HttpGet("/error")]
        public IActionResult Errors(int? statusCode)
        {
           
            if (statusCode.HasValue)
            {
                // here is the trick
                switch (statusCode)
                {
                    case 404:
                        return View("NotFound");


                    case 502:
                        return View("Erorr502");


                    case 500:
                        return View("Erorr500");




                    case 403:
                        return View("Erorr403");


                    default:
                        return View("Erorrs", statusCode);
                    break;
                }

               

            }
            return View("Erorrs", statusCode);

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
