using BoatReviews.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews
{
    public class BoatContext : DbContext
    {
        public DbSet<Boat> Boats { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BoatsTeam3C;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = 1,
                CategoryName = "Motorboats",
                CategoryImageLocation = "Img/Motorboat1.jpeg",
                CategoryContent = "Motorboats, also known as speedboats and powerboats, are boats propelled by an internal combustion or electric engine. Their length ranges from about 7 feet to 197 feet, while anything larger is called a ship. They are used recreationally and for sport, and come in many types, shapes, and sizes."
            },
            new Category()
            {
                Id = 2,
                CategoryName = "Sailboat",
                CategoryImageLocation = "Img/Sailboat1.jpeg",
                CategoryContent = "Sailboats are boats propelled partly or entirely by sails. They range in length from about 6 feet to 400 feet, the longer of which are called sailing ships. They are used recreationally and for sport and come in many types, shapes, and sizes."
            },
            new Category()
            {
                Id = 3,
                CategoryName = "Human Powered Boat",
                CategoryImageLocation = "Img/HPB1.jpg",
                CategoryContent = "Human-powered boats are propelled by human power. Human power is harnessed directly from the hands or feet, or through the hands and feet with oars, paddles, poles, pedals, or treadles. Their length ranges from about 3 feet to 144 feet. The are used recreationally and for sport and come in many types, shapes, and sizes."
            });

            modelBuilder.Entity<Boat>().HasData(
            new Boat()
            {
                Id = 1,
                CategoryId = 1,
                Name = "Nitro",
                ImageLocation = "Img/NitroBig.jpg",
                ReviewContent = "There are lots of bass boats around, and we doubt that one catches fish better than the others – despite boat builders' claims. The fact is that the Nitro Z-6 has all of the fishing amenities and equipment needed to put tournament anglers on top of the bass without draining the last drop from their bank accounts. The Nitro Z-6 costs about $21 grand, including a trailer and Mercury 115-hp OptiMax outboard. The Nitro Z - 6 is a good choice for beginning boat owners, club tournament anglers or anybody wanting to chase fish on a budget.And in case you are wondering, it is one of the best - selling brands on the market."
            },
            new Boat()
            {
                Id = 2,
                CategoryId = 1,
                Name = "Sea Ray",
                ImageLocation = "Img/SeaRayBig.jpg",
                ReviewContent = "Sea Ray has moved to fill a gap between its affordable “sport” lineup and the luxury SLX models and created a somewhat cost-conscious line that still embraces an upscale look. The result is the SPX Series. Affordable, but depending on how she gets optioned out, still embraces many of the amenities that the brand is well known for. Perhaps most importantly, the hulls are the same as her more expensive siblings, and for that reason we expect the ride and the handling to be on a par with them."
            },
            new Boat()
            {
                Id = 3,
                CategoryId = 1,
                Name = "Wellcraft",
                ImageLocation = "Img/WellcraftBig.jpg",
                ReviewContent = "The Wellcraft 182 Fisherman is a center console boat designed for coastal fishing that can double as a family boat for cruising excursions along the shoreline. A single 90 to 150 -hp outboard provides the power in a notched transom. Her hull with a relatively high freeboard for a boat in her class is one of her most important qualities."
            },
            new Boat()
            {
                Id = 4,
                CategoryId = 2,
                Name = "American14",
                ImageLocation = "Img/American14.jpg",
                ReviewContent = "The American 14.6 is designed for the beginning sailor or those who are seeking a large, stable sloop that offers hassle-free sailing. This sturdy, deep-cockpit daysailer features a 6-foot 2-inch beam, glass kick-up rudder, weighted glass centerboard, and a large built-in storage compartment under the deck. Simplicity is enhanced with color-coded main and jib lines, and features simple up and down colored lines for centerboard control. The American 14.6 is recognized as an extremely stable, large, dry, daysailer providing fun for all ages."
            },
            new Boat()
            {
                Id = 5,
                CategoryId = 2,
                Name = "Wind Blazer",
                ImageLocation = "Img/WindBlazer.jpg",
                ReviewContent = "The Wind Blazer is the perfect boat for the beginner or experienced skipper.  It is simple to rig, simple to sail, very durable, and full of performance.  It is also an ideal boat for training, rental, or resort use with features hard to find in other competitive boats of this size and price range.  The mainsail on the Wind Blazer is sleeved over a two piece mast, which makes transport easier.  The rudder system features a stainless steel rudder head and heavy duty stainless steel mounting bracket on the transom.  The hull is constructed of hand laid fiberglass utilizing a sandwich core of coremat. All the hardware is backed up with aluminum plates under the fiberglass instead of commonly used wood making all the hardware attachment points extremely strong. The high performance hull design features a high entry bow with a roll v, which is designed to lift the bow of the Wind Blazer through the waves and allow for greater performance from the planing hull."
            },
            new Boat()
            {
                Id = 6,
                CategoryId = 2,
                Name = "Aqua Cat",
                ImageLocation = "Img/Catamaran.jpg",
                ReviewContent = "One of the world's most popular one designs, catamarans bring you performance, simplicity, and weight carrying capabilities. Featuring wide, flat bottom hulls with turned up bows and a small keel skeg, the pontoon design is unequaled in weight carrying capacity and planing speed. The small keels have replaced the daggerboards used on the smaller Aqua Cat and allow for easy beaching thru the surf. Designed for ocean sailing or inland lakes this cat has it all. The Aqua Cat 14 is ideal for four large adults or where capabilities to support 1,000 lbs. are needed. Standard features include spring loaded kick up rudders, 105 sq. ft. Dacron two colored sail, a 360 quick release cleat and rudder lift systems. Available with white hulls with red side stripes and four sail combinations, the Aqua Cat offers a performance fun package not to be missed. Experience the Aqua Cat feeling."
            },
            new Boat()
            {
                Id = 7,
                CategoryId = 3,
                Name = "Edon",
                ImageLocation = "Img/Sculling.jpg",
                ReviewContent = "The most affordable recreational sculling boats in the USA, a rowing boat for all ages and all experience levels. A real rowing boat at an affordable price. We love Edon TS515 rowing boats with their fast streamlined but stable hull, they are light and easy to row and they come complete with removable pontoon stabilizers that keep the boat from flipping when learning or when rowing on cold water. Made of tough polyethylene that is damage resistant and unaffected by UV the Edon TS515 is the perfect rowing boat for exercise and fun, whether you are an experienced sculler or just starting out."
            },
            new Boat()
            {
                Id = 8,
                CategoryId = 3,
                Name = "Minto",
                ImageLocation = "Img/Minto9RowBoat.jpg",
                ReviewContent = "Rowboats, as opposed to canoes and kayaks, are propelled by oars that are held in place at a pivot point attached to the boat, the oarlocks (also called rowlocks). These pivot point do not change their position as the boat is rowed. This pivot point is a fulcrum if the oar is a lever. Rowers typically face the stern of the boat. Various clever mechanisms have been tried to allow the rower to face forward but none so far have been widely adopted."
            },
            new Boat()
            {
                Id = 9,
                CategoryId = 3,
                Name = "Pelican",
                ImageLocation = "Img/PedalBoat.jpg",
                ReviewContent = "A standard pedal boat is powered by people who are using the pedals, which turn a paddle wheel located under the watercraft. Pedal boats are a favorite choice for families mostly because of how simple they are to use and steer, and because they’re safe for the whole family. Both the pedals and the lever for steering are located in the front, so the adults are responsible for navigating around the water and powering the pedal boats, while kids enjoy in the back. If you’re out on the lake with your friends, you can switch between yourself so everyone gets a chance to try their hand at pedaling."
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}