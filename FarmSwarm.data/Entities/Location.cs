using System.Collections.Generic;

namespace FarmSwarm.data.Entities
{
    public class Location : EntityBase 
    {
        public virtual Condition CurrentCondition { get; set; }
        public virtual ICollection<Condition> ConditionHistory { get; set; }
        public virtual GreenHouse CurrentGreenHouse { get; set; }
    }
}
