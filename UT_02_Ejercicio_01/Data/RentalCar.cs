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

        public DbSet<UT_02_Ejercicio_01.Models.Car> Car { get; set; } = default!;
    }
}
