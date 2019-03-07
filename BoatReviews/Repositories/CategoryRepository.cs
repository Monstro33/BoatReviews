using BoatReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        BoatContext db;

        public CategoryRepository(BoatContext db)
        {
            this.db = db;
        }

        public IEnumerable<Boat> GetAll()
        {
            return db.Boats.ToList();
        }

        public object GetById(int id)
        {
            return db.Categories.Single(category => category.Id == id);
        }

        //object ICategoryRepository.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //object ICategoryRepository.GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
