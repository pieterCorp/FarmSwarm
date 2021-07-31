using FarmSwarm.data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace FarmSwarm.data.DataBase
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedGreenHouse(modelBuilder);
            SeedPlants(modelBuilder);            
        }
        private static void SeedGreenHouse(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GreenHouse>(x =>
            {
                x.HasData(

                    new GreenHouse { Id = 1, CreatedAt = DateTime.Now },
                    new GreenHouse { Id = 2, CreatedAt = DateTime.Now }

                    );
            });
        }
        private static void SeedPlants(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plant>(x =>
            {                
                x.HasData(
                    
                    new Plant { Id = 1, CreatedAt = DateTime.Now, Name = "basil", GreenHouseId = 1 },
                    new Plant { Id = 2, CreatedAt = DateTime.Now, Name = "tomato", GreenHouseId = 1 }

                    );
            });
        }        
    }
}
