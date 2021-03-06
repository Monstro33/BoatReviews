﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Models
{
    public class Category
    {
        public string CategoryName { get; set; }
        public int Id { get; set; }
        public string CategoryImageLocation { get; set; }
        public string CategoryContent { get; set; }
        public virtual IEnumerable<Boat> Boats { get; set; }


        public Category()
        {

        }
    }
}
