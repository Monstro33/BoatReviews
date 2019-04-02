using BoatReviews.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews
{
    public class CategoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=TM3CBoatCategories;Trusted_Connection=True;";

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


            base.OnModelCreating(modelBuilder);
        }

    }

}
