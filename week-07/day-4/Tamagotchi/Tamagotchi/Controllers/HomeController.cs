using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {
        IFroggy frogger;

        public HomeController (IFroggy frogger)
        {
            this.frogger = frogger;
        }
        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            
            return View(frogger);
        }
        [HttpGet]
        [Route("")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        public IActionResult Login(string givenName)
        {
            frogger.SetName(givenName);
            return RedirectToAction("index");
        }
        [HttpPost]
        [Route("trick")]
        public IActionResult Trick()
        {
            frogger.DoTrick();
            return RedirectToAction("index");
        }
    }
}
