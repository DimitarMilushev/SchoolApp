using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp.Data.Models
{
    public class Person : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PictureUrl { get; set; }

        public Role Role { get; set; }

        public string Department { get; set; }

    }
}
