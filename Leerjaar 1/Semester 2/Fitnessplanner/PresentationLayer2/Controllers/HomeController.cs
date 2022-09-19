using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PresentationLayer2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.sessionId =  HttpContext.Session.GetInt32("UserID") + "   " + HttpContext.Session.GetString("UserName") + "   " + HttpContext.Session.GetString("UserType") + "   " + HttpContext.Session.GetString("Subend");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
