﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AccessLevel.Controllers
{
    public class AboutUSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}