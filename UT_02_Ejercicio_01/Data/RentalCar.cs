using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UT_02_Ejercicio_01.Models;

namespace UT_02_Ejercicio_01.Data
{
    public class RentalCar : DbContext
    {
        public RentalCar (DbContextOptions<RentalCar> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    Model = "Ibiza",
                    Brand = "Seat",
                    ReleaseDate = new DateTime(2002,09,01),
                    Price = 20000
                },
                new Car
                {
                    Id = 2,
                    Model = "Ibiza",
                    Brand = "Leon",
                    ReleaseDate = new DateTime(2002, 10, 21),
                    Price = 22000
                },
                new Car
                {
                    Id = 3,
                    Model = "Renault",
                    Brand = "Megane",
                    ReleaseDate = new DateTime(2012, 07, 01),
                    Price = 25000
                }
             );
        }

        public DbSet<UT_02_Ejercicio_01.Models.Car> Car { get; set; } = default!;
    }
}
