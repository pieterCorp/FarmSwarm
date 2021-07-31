using System.ComponentModel.DataAnnotations.Schema;

namespace FarmSwarm.data.Entities
{
    public class Plant : EntityBase
    {
        public string Name { get; set; }

        [ForeignKey("GreenHouse")]
        public int GreenHouseId { get; set; }
        public virtual GreenHouse GreenHouse { get; set; }
    }
}
