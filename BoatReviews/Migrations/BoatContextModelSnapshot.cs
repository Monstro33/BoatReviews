﻿// <auto-generated />
using BoatReviews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoatReviews.Migrations
{
    [DbContext(typeof(BoatContext))]
    partial class BoatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoatReviews.Models.Boat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageLocation");

                    b.Property<string>("Name");

                    b.Property<string>("ReviewContent");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Boats");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, ImageLocation = "Img/NitroBig.jpg", Name = "Nitro", ReviewContent = "There are lots of bass boats around, and we doubt that one catches fish better than the others – despite boat builders' claims. The fact is that the Nitro Z-6 has all of the fishing amenities and equipment needed to put tournament anglers on top of the bass without draining the last drop from their bank accounts. The Nitro Z-6 costs about $21 grand, including a trailer and Mercury 115-hp OptiMax outboard. The Nitro Z - 6 is a good choice for beginning boat owners, club tournament anglers or anybody wanting to chase fish on a budget.And in case you are wondering, it is one of the best - selling brands on the market." },
                        new { Id = 2, CategoryId = 1, ImageLocation = "~/Img/SeaRayBig.jpg", Name = "Sea Ray", ReviewContent = "Sea Ray has moved to fill a gap between its affordable “sport” lineup and the luxury SLX models and created a somewhat cost-conscious line that still embraces an upscale look. The result is the SPX Series. Affordable, but depending on how she gets optioned out, still embraces many of the amenities that the brand is well known for. Perhaps most importantly, the hulls are the same as her more expensive siblings, and for that reason we expect the ride and the handling to be on a par with them." },
                        new { Id = 3, CategoryId = 1, ImageLocation = "Img/WellcraftBig.jpg", Name = "Wellcraft", ReviewContent = "The Wellcraft 182 Fisherman is a center console boat designed for coastal fishing that can double as a family boat for cruising excursions along the shoreline. A single 90 to 150 -hp outboard provides the power in a notched transom. Her hull with a relatively high freeboard for a boat in her class is one of her most important qualities." }
                    );
                });

            modelBuilder.Entity("BoatReviews.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryContent");

                    b.Property<string>("CategoryImageLocation");

                    b.Property<string>("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, CategoryContent = "Motorboats, also known as speedboats and powerboats, are boats propelled by an internal combustion or electric engine. Their length ranges from about 7 feet to 197 feet, while anything larger is called a ship. They are used recreationally and for sport, and come in many types, shapes, and sizes.", CategoryImageLocation = "Img/Motorboat1.jpeg", CategoryName = "Motorboats" },
                        new { Id = 2, CategoryContent = "Sailboats are boats propelled partly or entirely by sails. They range in length from about 6 feet to 400 feet, the longer of which are called sailing ships. They are used recreationally and for sport and come in many types, shapes, and sizes.", CategoryImageLocation = "Img/Sailboat1.jpeg", CategoryName = "Sailboat" },
                        new { Id = 3, CategoryContent = "Human-powered boats are propelled by human power. Human power is harnessed directly from the hands or feet, or through the hands and feet with oars, paddles, poles, pedals, or treadles. Their length ranges from about 3 feet to 144 feet. The are used recreationally and for sport and come in many types, shapes, and sizes.", CategoryImageLocation = "Img/HPB1.jpg", CategoryName = "Human Powered Boat" }
                    );
                });

            modelBuilder.Entity("BoatReviews.Models.Boat", b =>
                {
                    b.HasOne("BoatReviews.Models.Category", "Category")
                        .WithMany("Boats")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
