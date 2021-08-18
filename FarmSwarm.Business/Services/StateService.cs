using AutoMapper;
using FarmSwarm.Business.Dto;
using FarmSwarm.data.Entities;
using FarmSwarm.data.Repositories;
using System.Threading.Tasks;

namespace FarmSwarm.Business.Services
{
    public class StateService : IStateService
    {
        private readonly IGenericRepo<State> _stateRepo;
        private readonly IMapper _mapper;

        public StateService(IMapper mapper, IGenericRepo<State> stateRepo)
        {
            _mapper = mapper;
            _stateRepo = stateRepo;
        }

        public async Task<bool> AddState(StateDto stateDto)
        {
            return await _stateRepo.AddEntityAsync(_mapper.Map<State>(stateDto));
        }
    }
}