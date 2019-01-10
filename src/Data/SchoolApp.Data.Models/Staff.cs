using SchoolApp.Data.Common;

namespace SchoolApp.Data.Models
{
    public class Staff : BaseModel<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PictureUrl { get; set; }

        public Role Role { get; set; }

        public string Department { get; set; }

    }
}
