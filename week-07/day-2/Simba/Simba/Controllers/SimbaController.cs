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
        [Route("Simba")]
        public IActionResult Simba()
        {
            var bankAccount = new BankAccount("Simba", 2000, "Lion", true, "Good");
            return View(bankAccount);
        }
        [HttpGet]
        [Route("AnimalList")]
        public IActionResult AnimalList()
        {
            return View(Animals.bankAccounts);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AnimalList(int index)
        {
            if (Animals.bankAccounts.Count >= index && index > 0)
            {


                if (Animals.bankAccounts[index - 1].isKing)
                {
                    Animals.bankAccounts[index - 1].balance += 100;
                }
                else
                {
                    Animals.bankAccounts[index - 1].balance += 10;
                }
            }
            return View(Animals.bankAccounts);
     
        }
        [HttpPost]
        [Route("AddAccount")]
        public IActionResult AnimalList(string name, int balance, string animalType, bool isKing, string badOrGood)
        {
            Animals.bankAccounts.Add(new BankAccount(name, balance, animalType, isKing, badOrGood));
            return View(Animals.bankAccounts);

        }



    }
}
