using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Counter.Models;

namespace Counter.Controllers
{
    public class HomeController : Controller
    {
        ICountable countPlz;
        public HomeController (ICountable countPlz)
        {
            this.countPlz = countPlz;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(countPlz);
        }
        [HttpPost]
        [Route("Same")]
        public IActionResult Same()
        {
            countPlz.Count();
            return RedirectToAction("Index");
        }

    }
}
