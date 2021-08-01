using System.Collections.Generic;

namespace FarmSwarm.data.Entities
{
    public class Deck : EntityBase
    {
        public ICollection<GreenHouse> GreenHouses { get; set; }
        public ICollection<Location> Locations { get; set; }
    }
}
