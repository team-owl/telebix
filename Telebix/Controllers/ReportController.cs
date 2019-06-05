using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telebix.Models;

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

        public IActionResult StatReportIndex()
        {
            return View();
        }

        public IActionResult StatReportMarMay2019()
        {
            return View();
        }

        public IActionResult ErrorReport()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AppEvents()
        {
            return View("AppEventParams");
            //return View(AppEvent.LoadSampleData());
        }

        [HttpPost]
        public IActionResult AppEventsReport()
        {
            return View("AppEvents", AppEvent.LoadSampleData());
        }



        public IActionResult Phone(int Id)
        {
            List<AppEvent> data = AppEvent.LoadSampleData();
            var phoneEvents = data
                .Where(e => e.PhoneId == Id)
                .OrderByDescending(e => e.EventDt)
                .Take(20);
                   
            return View(phoneEvents);
        }
    }
}