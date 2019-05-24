using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Telebix.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewsArticle1()
        {
            return View();
        }

        public IActionResult NewsArticle2()
        {
            return View();
        }

        public IActionResult NewsArticle3()
        {
            return View();
        }

    }
}