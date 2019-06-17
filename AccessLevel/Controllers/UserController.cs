using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessLevel.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace AccessLevel.Controllers
{
    [HasModule(Title = "مبین",
       Description = "",
       Icon = "",
       Image = "",
       LinkName = "اضافه نمودن")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
    }
}