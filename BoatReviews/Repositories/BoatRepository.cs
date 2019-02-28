using BoatReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Repositories
{

    public class BoatRepository
    {
        BoatContext db;
        
        public BoatRepository(BoatContext db)
        {
            this.db = db;
        }

        public IEnumerable<Boat> GetAll()
        {
            return db.Boats.ToList();
        }

        public object GetById(int id)
        {
            return db.Boats.Single(boat => boat.Id == id);
        }
    }
}
