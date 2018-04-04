using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simba.Models;

namespace Simba.Controllers
{
    public class SimbaController : Controller
    {
        [Route ("Simba")]
        public IActionResult Simba()
        {
            var bankAccount = new BankAccount("Simba", 2000, "Lion", true, "Good");
            return View(bankAccount);
        }
        [Route("AnimalList")]
        public IActionResult AnimalList()
        {
            var bankAccounts = new AnimalList();
            return View(bankAccounts);
        }
    }
}
