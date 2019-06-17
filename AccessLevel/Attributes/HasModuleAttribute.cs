using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccessLevel.Attributes
{
    public class HasModuleAttribute : ActionFilterAttribute
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }

        public string Image { get; set; }

        public string LinkName { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.Result = new UnauthorizedResult();

            base.OnActionExecuting(context);
        }
    }
}
