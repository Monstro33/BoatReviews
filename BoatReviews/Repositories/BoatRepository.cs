using BoatReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Repositories
{

    public class BoatRepository : IBoatRepository
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

        public void Create(Boat boat )
        {
            db.Boats.Add(boat);
            db.SaveChanges(); 
        }
        public void Delete(Boat boat)
        {
            db.Boats.Remove(boat);
            db.SaveChanges();
        }
        public void Update(Boat boat)
        {
            db.Boats.Update(boat);
            db.SaveChanges();
        }

        Boat IBoatRepository.GetById(int id)
        {
            return db.Boats.Single(boat => boat.Id == id);
        }
    }
}
