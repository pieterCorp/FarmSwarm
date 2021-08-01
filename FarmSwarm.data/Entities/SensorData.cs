namespace FarmSwarm.data.Entities
{
    public class SensorData : EntityBase
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public int LightIntensity { get; set; }
    }
}
