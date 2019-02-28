using BoatReviews.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews
{
    public class BaseContext<TContext> : DbContext
   where TContext : DbContext
    {
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }
        protected BaseContext() : base()
        {
        }

        public class BoatContext : BaseContext<BoatContext>
        {
            public DbSet<Boat> Boats { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var connectionString = "Server=(localdb)\\mssqllocaldb;Database=TM3CBoatReviews;Trusted_Connection=True;";

                optionsBuilder.UseSqlServer(connectionString)
                              .UseLazyLoadingProxies();

                base.OnConfiguring(optionsBuilder);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Boat>().HasData(
                new Boat()
                {
                    Id = 1,
                    Name = "Nitro",
                    ImageLocation = "Img/NitroBig.jpg",
                    ReviewContent = "There are lots of bass boats around, and we doubt that one catches fish better than the others – despite boat builders' claims. The fact is that the Nitro Z-6 has all of the fishing amenities and equipment needed to put tournament anglers on top of the bass without draining the last drop from their bank accounts. The Nitro Z-6 costs about $21 grand, including a trailer and Mercury 115-hp OptiMax outboard. The Nitro Z - 6 is a good choice for beginning boat owners, club tournament anglers or anybody wanting to chase fish on a budget.And in case you are wondering, it is one of the best - selling brands on the market."
                },
                new Boat()
                {
                    Id = 2,
                    Name = "Sea Ray",
                    ImageLocation = "Img/SeaRayBig.jpg",
                    ReviewContent = "Sea Ray has moved to fill a gap between its affordable “sport” lineup and the luxury SLX models and created a somewhat cost-conscious line that still embraces an upscale look. The result is the SPX Series. Affordable, but depending on how she gets optioned out, still embraces many of the amenities that the brand is well known for. Perhaps most importantly, the hulls are the same as her more expensive siblings, and for that reason we expect the ride and the handling to be on a par with them."
                },
                new Boat()
                {
                    Id = 3,
                    Name = "Wellcraft",
                    ImageLocation = "Img/WellcraftBig.jpg",
                    ReviewContent = "The Wellcraft 182 Fisherman is a center console boat designed for coastal fishing that can double as a family boat for cruising excursions along the shoreline. A single 90 to 150 -hp outboard provides the power in a notched transom. Her hull with a relatively high freeboard for a boat in her class is one of her most important qualities."
                });


                base.OnModelCreating(modelBuilder);
            }
        }

        public class CategoryContext : BaseContext<CategoryContext>
        {
            public DbSet<Category> Categories { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var connectionString = "Server=(localdb)\\mssqllocaldb;Database=TM3CBoatReviews;Trusted_Connection=True;";

                optionsBuilder.UseSqlServer(connectionString)
                              .UseLazyLoadingProxies();

                base.OnConfiguring(optionsBuilder);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Motorboats",
                    CategoryImageLocation = "Img/Motorboat1.jpeg",
                    CategoryContent = "Motorboats, also known as speedboats and powerboats, are boats propelled by an internal combustion or electric engine. Their length ranges from about 7 feet to 197 feet, while anything larger is called a ship. They are used recreationally and for sport, and come in many types, shapes, and sizes."
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Sailboat",
                    CategoryImageLocation = "Img/Sailboat1.jpeg",
                    CategoryContent = "Sailboats are boats propelled partly or entirely by sails. They range in length from about 6 feet to 400 feet, the longer of which are called sailing ships. They are used recreationally and for sport and come in many types, shapes, and sizes."
                },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Human Powered Boat",
                    CategoryImageLocation = "Img/HPB1.jpg",
                    CategoryContent = "Human-powered boats are propelled by human power. Human power is harnessed directly from the hands or feet, or through the hands and feet with oars, paddles, poles, pedals, or treadles. Their length ranges from about 3 feet to 144 feet. The are used recreationally and for sport and come in many types, shapes, and sizes."
                });


                base.OnModelCreating(modelBuilder);
            }
        }

    }
}
