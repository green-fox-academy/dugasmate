using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GuardiansofTheGalaxy.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet]
        [Route("/groot")]
        public IActionResult Index()
        {
            return new JsonResult( new { received = "somemessage" });
        }

   }
}
