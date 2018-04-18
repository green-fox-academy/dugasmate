using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GuardiansVol2.Controllers
{
    public class GrootController : Controller
    {
        [HttpGet]
        [Route("groot")]
        public IActionResult Index(string message)
        {
            if (message != null)
            {
                return new JsonResult(new { received = message, translated = "I am Groot!" });
            }
            else
            {

                return new JsonResult(new { error = "I am Groot!" });
            }
        }

    }
}
