using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elso.Models;
using Microsoft.AspNetCore.Mvc;

namespace Elso.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        [Route("greeting")]
        
        public IActionResult Greeting(string name)
        { 
            Greeting greeting = new Greeting($"Hello {name}");
            return new JsonResult(greeting);
        }
        
    }
}