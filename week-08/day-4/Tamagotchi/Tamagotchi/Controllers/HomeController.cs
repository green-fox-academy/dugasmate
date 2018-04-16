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
            return RedirectToAction("frame");
        }
        [HttpPost]
        [Route("trick")]
        public IActionResult Trick(int i)
        {
            frogger.DoTrick(i);
            return RedirectToAction("index");
        }
        [HttpGet]
        [Route("trickstore")]
        public IActionResult TrickStore()
        {
            return View(frogger);
        }
        [HttpGet]
        [Route("nutritionstore")]
        public IActionResult NutritionStore()
        {
            return View(frogger);
        }
        [HttpGet]
        [Route("addnutrition")]
        public IActionResult AddNutrition(int i, int i2)
        {
            frogger.AddFood(i);
            frogger.AddDrink(i2);
            return RedirectToAction("index");
        }
        [HttpGet]
        [Route("addtrick")]
        public IActionResult AddTrick(int i)
        {
            frogger.AddTrick(i);
            return RedirectToAction("trickstore");
        }
        [Route("frame")]
        public IActionResult Frame()
        {
            return View();
        }
    }
}
