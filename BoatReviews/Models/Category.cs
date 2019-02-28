using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Models
{
    public class Category
    {
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryImageLocation { get; set; }
        public string CategoryContent { get; set; }
    }
}
