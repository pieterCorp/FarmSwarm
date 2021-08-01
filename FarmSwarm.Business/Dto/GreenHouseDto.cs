using System.Collections.Generic;

namespace FarmSwarm.Business.Dto
{
    public class GreenHouseDto
    {
        public ICollection<PlantDto> Plants { get; set; }
        public ICollection<StateDto> StateHistory { get; set; }
    }
}
