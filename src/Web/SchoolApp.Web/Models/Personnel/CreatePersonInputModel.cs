using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Web.Models.Personnel
{
    public class CreatePersonInputModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PictureUrl { get; set; }

        public string Role { get; set; }

        public string Department { get; set; }
    }
}
