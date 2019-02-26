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
            new Boat(1, "Nitro", "Img/NitroBig.jpg"),
            new Boat(2, "Sea Ray", "Img/SeaRayBig.jpg"),
            new Boat(3, "Wellcraft", "Img/WellcraftBig.jpg")
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
