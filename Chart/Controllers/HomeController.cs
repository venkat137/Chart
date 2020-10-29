using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chart.Models;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Chart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<DateTime> date = new List<DateTime>();
            date.Add(DateTime.Today);
            date.Add(DateTime.Today.AddDays(-1));
            date.Add(DateTime.Today.AddDays(-2));

            List<double> close = new List<double>();
            close.Add(23.5);
            close.Add(25);
            close.Add(26.5);

            ViewBag.Date = JsonConvert.SerializeObject(date);
            ViewBag.Close = JsonConvert.SerializeObject(close);

            return View();
        }
    }
}
