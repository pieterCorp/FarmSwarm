using System;

namespace FarmSwarm.Business.Dto
{
    public class StateDto
    {
        public int GreenHouseId { get; set; }
        public DateTime CreatedAt { get; set; }
        public SensorDataDto SensorData { get; set; }
        public LocationDto Location { get; set; }        
    }
}
