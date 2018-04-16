using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheRedditApp.Models;
using TheRedditApp.Repos;

namespace TheRedditApp.Controllers
{
    public class HomeController : Controller
    {
        IRepo repository;
        public HomeController(IRepo repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View(repository.Read());
        }

        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("add")]
        public IActionResult Add(string title, string content, string link)
        {
            if (title != null && content != null)
            {
                repository.Create(new Post() { Title = title, Content = content, Link = link });
            }
            return RedirectToAction("");
        }

        [Route("postcontent/{id}")]
        public IActionResult PostContent(int id)
        {

            return View(repository.Search(id));
        }
        [Route("postcontent/{id}/comment")]
        public IActionResult Comment(int id, string comment)
        {
            repository.Comment(id, comment);
            return RedirectToAction("PostContent");
        }

        [Route("increaselikes/{id}")]
        public IActionResult IncreaseLikes(int id)
        {
            repository.IncreaseLike(id);
            return RedirectToAction("");
        }

        [Route("decreaselikes/{id}")]
        public IActionResult DecreaseLikes(int id)
        {
            repository.DecreaseLike(id);
            return RedirectToAction("");
        }
    }
}
