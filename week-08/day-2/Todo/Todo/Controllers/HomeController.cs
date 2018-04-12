using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers
{
    [Route("todo")]
    public class HomeController : Controller
    {
        IRepo repository;
        public HomeController (IRepo repository)
        {
            this.repository = repository;
        }
        [Route("list")]
        public IActionResult List()
        {
            
            return View(repository.Read()) ;
        }
        [Route("search")]
        public IActionResult List(string title)
        {

            return View(repository.Search(title));
        }
        [Route("create")]
        public IActionResult Create(string title)
        {
            repository.Create(new TodoC() {Title=title });
            return RedirectToAction("list");
        }
        [Route("remove")]
        public IActionResult Remove(int id)
        {
            repository.Delete(id);
            return RedirectToAction("list");
        }
        [Route("update")]
        public IActionResult Remove(int id, string updated)
        {
            repository.Update(id, updated);
            return RedirectToAction("list");
        }
        [Route("maketrue")]
        public IActionResult Done(int id)
        {
            repository.MakeTrue(id);
            return RedirectToAction("list");
        }

    }
}
