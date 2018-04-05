using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Greet.Models;

namespace Greet.Controllers
{
    public class HomeController : Controller
    {
        IGreetable szevasz;
        
        public HomeController (IGreetable szevasz)
        {
            this.szevasz = szevasz;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(szevasz);
        }
        [HttpPost]
        [Route("AddName")]
        public IActionResult Index(string name)
        {
            szevasz.Greet(name);
            return RedirectToAction("Greetings");
        }
        [HttpGet]
        [Route("Greetings")]
        public IActionResult Greetings()
        {
            return View(szevasz);
        }
    }
}
