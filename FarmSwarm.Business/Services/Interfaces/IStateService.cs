using FarmSwarm.Business.Dto;
using System.Threading.Tasks;

namespace FarmSwarm.Business.Services
{
    public interface IStateService
    {
        Task<bool> AddState(StateDto stateDto);
    }
}