using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoatReviews.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BoatReviews.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepo;

        public CategoryController(CategoryRepository categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public ViewResult Index()
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }
    }
}