using System.Collections.Generic;

namespace FarmSwarm.data.Entities
{
    public class GreenHouse : EntityBase
    {
        public virtual ICollection<Plant> Plants { get; set; }               
        public virtual ICollection<State> StateHistory { get; set; }
    }
}
