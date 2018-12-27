using Microsoft.AspNetCore.Mvc;
using SchoolApp.Web.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Web.Controllers
{
    public class AboutController : BaseController
    {
        public IActionResult History() => this.View();

        public IActionResult Contacts() => this.View();

    }
}
