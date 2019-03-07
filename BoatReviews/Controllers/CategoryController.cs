﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoatReviews.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BoatReviews.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryRepository categoryRepo;

        public CategoryController(ICategoryRepository categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public ViewResult Index()
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = categoryRepo.GetById(id);
            return View(model);
        }
        public string Foo(int id)
        {
            return (id.ToString());
        }
    }
}