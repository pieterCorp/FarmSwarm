using FarmSwarm.data.DataBase;
using FarmSwarm.data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FarmSwarm.data.Repositories
{
    public class GreenHouseRepo : GenericRepo<GreenHouse>, IGreenHouseRepo
    {
        public GreenHouseRepo(FarmSwarmContext context) : base(context)
        {
        }

        public override async Task<GreenHouse> GetEntityAsync(int id)
        {
            return await _context.Set<GreenHouse>()
                                 .Include(x => x.Plants)
                                 .Include(x => x.StateHistory)
                                 .ThenInclude(x => x.SensorData)
                                 .Include(x => x.StateHistory)
                                 .ThenInclude(x => x.Location)
                                 .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
