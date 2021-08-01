namespace FarmSwarm.Business.Dto
{
    public class SensorDataDto
    {
        public int Id { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public int LightIntensity { get; set; }
    }
}
