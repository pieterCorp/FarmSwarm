using FarmSwarm.Business.Dto;
using System.Threading.Tasks;

namespace FarmSwarm.Business.Services
{
    public interface IGreenHouseService
    {
        Task<GreenHouseDto> GetGreenHouseByIdAsync(int id);
    }
}