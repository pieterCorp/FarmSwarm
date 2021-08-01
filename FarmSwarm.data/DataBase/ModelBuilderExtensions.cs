using FarmSwarm.data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace FarmSwarm.data.DataBase
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedGreenHouses(modelBuilder);
            SeedPlants(modelBuilder);
            SeedDecks(modelBuilder);
            SeedLocations(modelBuilder);
        }
        private static void SeedGreenHouses(ModelBuilder modelBuilder)
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
        private static void SeedDecks(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deck>(x =>
            {
                x.HasData(

                    new Deck { Id = 1, CreatedAt = DateTime.Now },
                    new Deck { Id = 2, CreatedAt = DateTime.Now }

                    );
            });
        }
        private static void SeedLocations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>(x =>
            {
                x.HasData(

                    new Location { Id = 1, CreatedAt = DateTime.Now, DeckId = 1, DeckPosition = 1 },
                    new Location { Id = 2, CreatedAt = DateTime.Now, DeckId = 1, DeckPosition = 2 },
                    new Location { Id = 3, CreatedAt = DateTime.Now, DeckId = 1, DeckPosition = 3 },
                    new Location { Id = 4, CreatedAt = DateTime.Now, DeckId = 1, DeckPosition = 4 },
                    new Location { Id = 5, CreatedAt = DateTime.Now, DeckId = 1, DeckPosition = 5 },
                    new Location { Id = 6, CreatedAt = DateTime.Now, DeckId = 1, DeckPosition = 6 }

                    );
            });
        }
    }
}
