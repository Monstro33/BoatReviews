using BoatReviews.Models;
using BoatReviews.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Controllers
{
    public class BoatController : Controller
    {
        private IBoatRepository repo;

        public BoatController(IBoatRepository repo)
        {
            this.repo = repo;
        }

        public ViewResult Index()
        {
            var model = repo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = repo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Boat boat)
        {
            repo.Create(boat);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = repo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(Boat boat)
        {
            repo.Delete(boat);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = repo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Boat boat)
        {
            repo.Update(boat);
            return RedirectToAction("Details/" + boat.Id);
        }
    }
}
 