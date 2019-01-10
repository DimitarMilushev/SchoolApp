using SchoolApp.Data.Models;
using SchoolApp.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Services.Models.Council
{
    public class CouncilDetailsViewModel : IMapFrom<Person>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Role { get; set; }

        public string Department { get; set; }

        public string PictureUrl { get; set; }
    }
}
