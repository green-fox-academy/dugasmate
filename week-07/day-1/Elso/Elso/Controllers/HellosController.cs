using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elso.Models;
using Microsoft.AspNetCore.Mvc;

namespace Elso.Controllers
{
    [Route("hellos")]
    public class HellosController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var hellosGreeting = new HellosGreeting();
            return View(hellosGreeting);
        }

    }
}