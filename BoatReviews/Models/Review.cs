using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Models
{
    public class Review
    {
        int Id { get; set; }
        string Title { get; set; }
        string ImageUrl { get; set; }
        string ReviewCategory { get; set; }
        string Content { get; set; }
    }
}
