using FarmSwarm.data.Entities;
using System.Threading.Tasks;

namespace FarmSwarm.data.Repositories
{
    public interface IGreenHouseRepo
    {
        Task<GreenHouse> GetEntityAsync(int id);
    }
}