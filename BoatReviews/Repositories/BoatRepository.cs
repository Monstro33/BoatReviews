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
            {1, new Boat() { Id = 1, Name = "Motorboat", ImageLocation = "Img/Motorboat1.jpeg" } },
            {2, new Boat() { Id = 2, Name = "Sailboat", ImageLocation = "Img/Sailboat1.jpeg" } },
            {3, new Boat() { Id = 3, Name = "Human Powered Boat", ImageLocation = "Img/HPB1.jpg" } }
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
