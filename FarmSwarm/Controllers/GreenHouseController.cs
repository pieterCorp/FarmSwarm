using FarmSwarm.Business.Dto;
using FarmSwarm.Business.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FarmSwarm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreenHouseController : ControllerBase
    {
        private readonly IStateService _stateService;
        private readonly IGreenHouseService _greenHouseService;

        public GreenHouseController(IStateService stateService, IGreenHouseService greenHouseService)
        {
            _stateService = stateService;
            _greenHouseService = greenHouseService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GreenHouseDto>> GetGreenHouse(int id)
        {
            return Ok(await _greenHouseService.GetGreenHouseByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddState(StateDto stateDto)
        {
            stateDto.CreatedAt = DateTime.Now;
            return Ok(await _stateService.AddState(stateDto));
        }
    }
}
