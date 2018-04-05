using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        IToDoable plzWork;
        public HomeController (IToDoable plzWork)
        {
            this.plzWork = plzWork;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View(plzWork);
        }
        [Route("Add")]
        public IActionResult Add(string task)
        {
            plzWork.Add(task);
            return RedirectToAction("Index");
        }
        [Route("Remove")]
        public IActionResult Remove(int index)
        {
            plzWork.Remove(index-1);
            return RedirectToAction("Index");
        }
        [Route("Check")]
        public IActionResult Check(int index)
        {
            plzWork.Check(index - 1);
            return RedirectToAction("Index");
        }
    }
}
