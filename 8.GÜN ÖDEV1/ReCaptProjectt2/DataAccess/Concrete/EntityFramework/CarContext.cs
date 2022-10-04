﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CARS;Integrated Security=True");

        }
        public DbSet<Car> CarTable { get; set; }
        public DbSet<Color> ColorTable { get; set; }
        public DbSet<Brand> BrandTable { get; set; }
    }
}
