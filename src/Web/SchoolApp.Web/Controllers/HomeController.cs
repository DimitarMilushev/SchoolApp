using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Web.Controllers.Base;
using SchoolApp.Web.Models;

namespace SchoolApp.Web.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index() => this.View();

        public IActionResult History() => this.View();

        public IActionResult Contacts() => this.View();


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

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
