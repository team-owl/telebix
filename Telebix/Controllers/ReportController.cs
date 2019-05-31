using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Telebix.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RiskFactorsReport()
        {
            return View();
        }

        public IActionResult CoverageReport()
        {
            return View();
        }

        public IActionResult ErrorReport()
        {
            return View();
        }
    }
}