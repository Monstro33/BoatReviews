using BoatReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Repositories
{
    public class CategoryRepository
    {
        BoatContext db;

        public CategoryRepository(BoatContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.Single(category => category.Id == id);
        }
    }
}
