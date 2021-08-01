using AutoMapper;
using FarmSwarm.Business.Dto;
using FarmSwarm.data.Repositories;
using System.Threading.Tasks;

namespace FarmSwarm.Business.Services
{
    public class GreenHouseService : IGreenHouseService
    {
        private readonly IGreenHouseRepo _greenHouseRepo;
        private readonly IMapper _mapper;

        public GreenHouseService(IMapper mapper, IGreenHouseRepo greenHouseRepo)
        {
            _mapper = mapper;
            _greenHouseRepo = greenHouseRepo;
        }

        public async Task<GreenHouseDto> GetGreenHouseByIdAsync(int id)
        {
            return _mapper.Map<GreenHouseDto>(await _greenHouseRepo.GetEntityAsync(id));
        }
    }
}
