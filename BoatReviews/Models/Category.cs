using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Models
{
    public class Category
    {
        public string CategoryName { get; set; }
        //public int CategoryId { get; set; }
        public int Id { get; set; }
        public string CategoryImageLocation { get; set; }
        public string CategoryContent { get; set; }
        //public string CategoryURL { get; set; } /* I was going to add a link from Motorboats to the list of Motorboats, but not yet -Joe */
        public virtual IEnumerable<Boat> Boats { get; set; }


        public Category()
        {

        }
    }
}
