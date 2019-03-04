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


    }
}
 