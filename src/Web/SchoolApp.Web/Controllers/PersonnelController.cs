using Microsoft.AspNetCore.Mvc;
using SchoolApp.Web.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Web.Controllers
{
    public class PersonnelController : BaseController
    {
        public IActionResult Council() => this.View();

        public IActionResult Teachers() => this.View();

        public IActionResult Administration() => this.View();

        public IActionResult Pedagogue() => this.View();

    }
}
