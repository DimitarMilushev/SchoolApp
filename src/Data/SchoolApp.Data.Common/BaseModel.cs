using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp.Data.Common
{
    public class BaseModel<T>
    {
        public T Id { get; set; }
    }
}
