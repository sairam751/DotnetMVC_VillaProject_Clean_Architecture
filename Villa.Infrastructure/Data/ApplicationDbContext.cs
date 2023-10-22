using Microsoft.EntityFrameworkCore;
using Villa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Infrastructure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option): base(option)
        {

        }
        public DbSet<VillaTable> Villas { get; set; }
        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VillaTable>().HasData(
                new VillaTable
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Description = "Villa 1",
                    ImageUrl = "",
                    Occupancy=4,
                    price=200,
                    sqft=500
                },
                  new VillaTable
                  {
                      Id = 2,
                      Name = "Pool Villa",
                      Description = "Villa 2",
                      ImageUrl = "",
                      Occupancy = 5,
                      price = 400,
                      sqft = 900
                  }, new VillaTable
                  {
                      Id = 3,
                      Name = " Sun Villa",
                      Description = "Villa 3",
                      ImageUrl = "",
                      Occupancy = 2,
                      price = 300,
                      sqft = 400
                  }
                ) ;
           
        }
    }
}
