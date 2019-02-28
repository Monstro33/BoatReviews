﻿using BoatReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Repositories
{
    public class CategoryRepository
    {
        CategoryContext db;

        public CategoryRepository(CategoryContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
            //return SomeBoats.Values.ToList();
        }

        public object GetById(int id)
        {
            return db.Categories.Single(category => category.Id == id);
            //return SomeBoats[id];
        }
    }
}
