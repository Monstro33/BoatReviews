using BoatReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Repositories
{

    public class BoatRepository
    {
        private BoatContext db;
        
        public BoatRepository(BoatContext db)
        {
            this.db = db;
        }
        public Dictionary<int, Boat> SomeBoats = new Dictionary<int, Boat>()
        {
            {1, new Boat(1, "Nitro", "Img/NitroBig.jpg") },
            {2, new Boat(2, "Sea Ray", "Img/SeaRayBig.jpg") },
            {3, new Boat(3, "Wellcraft", "Img/WellcraftBig.jpg") }
        };

        public IEnumerable<Boat> GetAll()
        {
            return db.Boats.ToList();
            //return SomeBoats.Values.ToList();
        }

        public object GetById(int id)
        {
            return db.Boats.Single(boat => boat.Id == id);
            //return SomeBoats[id];
        }
    }
}

//{1, new Boat() { Id = 1, Name = "Nitro", ImageLocation = "Img/NitroBig.jpg" } },
//            {2, new Boat() { Id = 2, Name = "Sea Ray", ImageLocation = "Img/SeaRayBig.jpg" } },
//            {3, new Boat() { Id = 3, Name = "Wellcraft", ImageLocation = "Img/WellcraftBig.jpg" } }