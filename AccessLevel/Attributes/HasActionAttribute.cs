using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessLevel.Attributes
{
    public class HasActionAttribute : ActionFilterAttribute
    {
        public string Title { get; set; }

        public string RelativePath { get; set; }
    }
}
