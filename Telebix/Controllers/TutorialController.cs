﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Telebix.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tutorial1()
        {
            return View();
        }

        public IActionResult Tutorial2()
        {
            return View();
        }

        public IActionResult Tutorial3()
        {
            return View();
        }
    }
}