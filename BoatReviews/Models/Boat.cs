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
        public List<string> Reviews { get; set; }
        public List<string> Images { get; set; }

        private Details details = new Details();


        public Boat(int id, string name, string imageLocation)
        {
            Name = name;
            Id = id;
            ImageLocation = imageLocation;

            switch (Id)
            {
                case 1:
                    Reviews = details.GetNitroReviews();
                    Images = details.GetNitroImages();
                    break;

                case 2:
                    Reviews = details.GetSeaRayReviews();
                    Images = details.GetSeaRayImages();
                    break;

                case 3:
                    Reviews = details.GetWellcraftReviews();
                    Images = details.GetWellcraftImages();
                    break;
            }
        }

        public Boat()
        {
        }
    }

}
