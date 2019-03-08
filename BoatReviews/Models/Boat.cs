using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Models
{
    public class Boat
    {
        [Display(Name = "Boat Name")]
        public string Name { get; set; }
        public int Id { get; set; }
        [Display(Name = "Image URL")]
        public string ImageLocation { get; set; }
        [Display(Name = "Review")]
        public string ReviewContent { get; set; }
        public virtual Category Category { get; set; }
        [Display(Name = "Boat Category")]
        public int CategoryId { get; set; }
        public Boat()
        {

        }

    
}   }


