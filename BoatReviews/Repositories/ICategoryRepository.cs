using BoatReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Repositories
{
    public interface ICategoryRepository
    {
            IEnumerable<Category> GetAll();
            Category GetById(int id);
        //    void Create(Boat boat);
        //    void Delete(Boat boat);
        //    void Update(Boat boat);
    }
}
