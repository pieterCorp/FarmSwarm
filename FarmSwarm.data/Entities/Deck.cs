using System.Collections.Generic;

namespace FarmSwarm.data.Entities
{
    public class Deck : EntityBase
    {
        public ICollection<Location> Locations { get; set; }
    }
}
