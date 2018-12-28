using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SchoolApp.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult History()
        {
            return View();
        }

    }
}