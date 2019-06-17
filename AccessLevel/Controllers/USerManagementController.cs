using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessLevel.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace AccessLevel.Controllers
{
    [HasModule(Title = "مدیریت کاربران",
        Description = "",
        Icon = "",
        Image = "",
        LinkName = "مدیریت")]
    public class UserManagementController : Controller
    {
        [HasAction(Title = "مشاهده کاربران")]
        public IActionResult Index()
        {
            return View();
        }

        [HasAction(Title = "حذف کاربران")]
        public IActionResult Delete()
        {
            return View();
        }
    }
}