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
        BoatRepository boatRepo;

        public BoatController(BoatRepository boatRepo)
        {
            this.boatRepo = boatRepo;
        }

        public ViewResult Index()
        {
            var model = boatRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = boatRepo.GetById(id);
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
            boatRepo.Create(boat);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = boatRepo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(Boat boat)
        {
            boatRepo.Delete(boat);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = boatRepo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Boat boat)
        {
            boatRepo.Edit(boat);
            return RedirectToAction("Details/" + boat.Id);
        }
    }
}
 