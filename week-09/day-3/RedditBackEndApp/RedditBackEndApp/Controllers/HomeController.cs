using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditBackEndApp.Models;
using RedditBackEndApp.Repository;

namespace RedditBackEndApp.Controllers
{
    public class HomeController : Controller
    {
        IRepo<Post> repository;
        public HomeController(IRepo<Post> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [Route("posts")]
        public IActionResult Posts()
        {
            return new JsonResult(new { posts = repository.Read()});
        }
        [HttpPost]
        [Route("posts")]
        public IActionResult Posts([FromBody] Post input)
        {
            repository.Create(input);
            return new JsonResult(new { input });
        }
        [HttpPut]
        [Route("posts/{id}/upvote")]
        public IActionResult Upvote(int id)
        {
            return new JsonResult(  repository.Update(id) );
       
        }
        [HttpPut]
        [Route("posts/{id}")]
        public IActionResult Modify(int id, [FromBody] Post input)
        {
            return new JsonResult(repository.Modify(id, input));

        }
        [HttpDelete]
        [Route("posts/{id}")]
        public IActionResult Delete(int id)
        {
            return new JsonResult(repository.Delete(id));

        }
    }
}
