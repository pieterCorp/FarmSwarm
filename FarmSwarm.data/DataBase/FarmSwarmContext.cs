using FarmSwarm.data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FarmSwarm.data.DataBase 
{
    public class FarmSwarmContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<GreenHouse> GreenHouses { get; set; }
        public DbSet<SensorData> SensorData { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<State> States { get; set; }

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
