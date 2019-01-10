using Microsoft.AspNetCore.Mvc;
using SchoolApp.Services.DataServices.Council;
using SchoolApp.Services.Models.Council;
using SchoolApp.Web.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Web.Controllers
{
    public class PersonnelController : BaseController
    {
        private readonly ICouncilService councilService;

        public PersonnelController(ICouncilService councilService)
        {
            this.councilService = councilService;
        }

        public async Task<IActionResult> Council()
        {
            var council = this.councilService.GetCouncilAsync();

            var model = new CouncilViewModel { Councils = await council };

            return this.View(model);
        }


        public IActionResult Teachers() => this.View();

        public IActionResult Administration() => this.View();

        public IActionResult Pedagogue() => this.View();

    }
}
