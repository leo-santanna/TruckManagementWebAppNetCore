using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruckManagementWebAppNetCore.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TruckModel>().HasData(
                new TruckModel { Id = 1, Name = "FH"},
                new TruckModel { Id = 2, Name = "FM" },
                new TruckModel { Id = 3, Name = "A1" },
                new TruckModel { Id = 4, Name = "A2" },
                new TruckModel { Id = 5, Name = "A3" }
                );
        }

        public DbSet<Truck> Trucks { get; set; }
        public DbSet<TruckModel> Models { get; set; }


    }
}
