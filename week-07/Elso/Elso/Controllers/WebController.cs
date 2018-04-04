using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elso.Models;
using Microsoft.AspNetCore.Mvc;

namespace Elso.Controllers
{

            [Route("web")]
        public class WebController : Controller
        {
            [Route("greeting")]
            public IActionResult Greeting(string name)
            {
            var greeting = new Greeting(name);
            return View(greeting);
            }

        }
    
}
