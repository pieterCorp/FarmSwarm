using FarmSwarm.data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace FarmSwarm.data.DataBase 
{
    public class FarmSwarmContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<GreenHouse> GreenHouses { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Location> Locations { get; set; }

        public FarmSwarmContext(DbContextOptions options)
            : base(options)
        {                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

           
        }
        
    }
}
