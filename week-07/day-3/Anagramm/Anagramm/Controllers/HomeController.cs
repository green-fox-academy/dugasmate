using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Anagramm.Models;

namespace Anagramm.Controllers
{
    public class HomeController : Controller
    {
        IAnagrammable anagrammCheck;
        public HomeController (IAnagrammable anagrammCheck)
        {
            this.anagrammCheck = anagrammCheck;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Check")]
        public IActionResult Check(string firstWord, string secondWord)
        {
            return View(anagrammCheck.IsAnagramm(firstWord, secondWord));
        }
    }
}
