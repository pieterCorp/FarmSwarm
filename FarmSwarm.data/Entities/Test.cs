using System;

namespace FarmSwarm.data.Entities
{
    public class Test
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
    }
}
