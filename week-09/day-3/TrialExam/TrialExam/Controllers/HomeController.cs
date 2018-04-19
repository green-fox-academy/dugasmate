using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrialExam.Models;
using TrialExam.Repository;
using TrialExam.ViewModel;

namespace TrialExam.Controllers
{
    public class HomeController : Controller
    {
        IRepositoru repository;
        public HomeController(IRepositoru repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            PlanetsAndSpaceship model = new PlanetsAndSpaceship();
            model.uhajo = repository.Read().Spaceship;
            model.Planets = repository.Read().Planet;
            return View(model);
        }
        [Route("create")]
        public IActionResult Create(Planet input)
        {
            repository.Create(input);
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Route("movehere/{id}")]
        public IActionResult Move(int id)
        {
            repository.Move(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("toship/{id}")]
        public IActionResult ToShip(int id)
        {
            repository.ToShip(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("toplanet/{id}")]
        public IActionResult ToPlanet(int id)
        {
            repository.ToPlanet(id);
            return RedirectToAction("Index");
        }


    }
}
