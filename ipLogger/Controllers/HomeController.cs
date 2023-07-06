using ipLogger.Entities;
using ipLogger.Models;
using ipLogger.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ipLogger.Controllers
{
    public class HomeController : Controller
    {
      
        ipServices ipServices =  new ipServices();
        public IActionResult Index()
        {
            var data = ipServices.Getip();
            return View(data);
        }

        [HttpPost]
        public IActionResult SaveIpAddress(ip ipAdd)
        {
            ipServices.saveip(ipAdd);

            return Json(new { success = true });
        }
    }
}