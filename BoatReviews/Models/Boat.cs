using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Models
{
    public class Boat
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string ImageLocation { get; set; }
        public string ReviewContent { get; set; }
        
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

        public Boat()
        {

        }

    
}   }


