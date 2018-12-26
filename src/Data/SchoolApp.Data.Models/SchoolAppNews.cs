using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp.Data.Models
{
    public class SchoolAppNews
    {
        public string Title { get; set; }

        public string MainPhoto { get; set; }

        public ICollection<string> Photos { get; set; }

        public string Description { get; set; }
    }
}
