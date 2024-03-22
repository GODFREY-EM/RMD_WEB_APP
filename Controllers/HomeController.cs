using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; // Add this namespace
using System.Net.Mail;
using RMD.Models;

namespace RMD.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult ServiceDetails()
        {
            return View();
        }

        public IActionResult StorageServiceDetails()
        {
            return View();
        }

        public IActionResult LogisticsServiceDetails()
        {
            return View();
        }

        public IActionResult TruckingServiceDetails()
        {
            return View();
        }

        public IActionResult CargoServiceDetails()
        {
            return View();
        }

        public IActionResult PackagingServiceDetails()
        {
            return View();
        }

        public IActionResult WarehousingServiceDetails()
        {
            return View();
        }



        public IActionResult Contact()
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
