using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }
        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return new JsonResult(new { error = "Please provide an input!" });
            }

            return new JsonResult(new { received = input, result = input * 2 });
        }
        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            {
            if (name == null)

                return new JsonResult(new { error = "Please provide a name!" });
            }
            if (title == null)
            {
                return new JsonResult(new { error = "Please provide a title!" });
            }

            return new JsonResult(new { welcome_message = "Oh, hi there " + name + ", my dear " + title + "!"});
        }
        [HttpGet]
        [Route("/appenda/{appendable}")]
        public IActionResult Appenda(string appendable)
        {

            return new JsonResult(new { appended = appendable + "a" });
        }
        [HttpGet]
        [Route("/appenda/")]
        public IActionResult Appenda404()
        {

            return StatusCode(404);
        }
        [HttpPost]
        [Route("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody] UntilClass until)
        {

            int result = 1;
            if (what == "sum")
            {
                if (until.Until == null)
                {
                    return new JsonResult(new { error = "Please provide a number!" });
                }
                result = 0;
                for (int i = 1; i <= until.Until; i++)
                {
                    result += i;

                }
                return new JsonResult(new {result });
            }
            if (what == "factor")
            {
                for (int i = 1; i <= until.Until; i++)
                {
                    result *= i;

                }
                return new JsonResult(new { result });
            }
            return new JsonResult(new { error = "Please provide a number!" });
        }
    }
    
}
