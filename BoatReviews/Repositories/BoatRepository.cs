using BoatReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Repositories
{
    public class BoatRepository
    {
        public Dictionary<int, Boat> SomeBoats = new Dictionary<int, Boat>()
        {
            {1, new Boat() { Id = 1, Name = "Motorboat"}},
            {2, new Boat() { Id = 2, Name = "Sailboat" } },
            {3, new Boat() { Id = 3, Name = "Man-Powered Boat" } }
        };

        public IEnumerable<Boat> GetAll()
        {
            return SomeBoats.Values.ToList();
        }

        public object GetById(int id)
        {
            return SomeBoats[id];
        }
    }
}
