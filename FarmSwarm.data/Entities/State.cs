 namespace FarmSwarm.data.Entities
{
    public class State : EntityBase
    {
        public int SensorDataId { get; set; }
        public virtual SensorData SensorData { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public int GreenHouseId { get; set; }
        public virtual GreenHouse GreenHouse { get; set; }
    }        
}
