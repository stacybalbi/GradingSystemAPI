using GradingSystem.Application.DayList.Dto;
using GradingSystem.Application.DayList.Handlers;
using GradingSystem.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace GradingSystemAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DayListController : ControllerBase
    {
        private readonly IDayListHandler _DayListHandler;
        public DayListController(IDayListHandler DayListHandler)
        {
            _DayListHandler = DayListHandler;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var entityToReturn = await _DayListHandler.GetById(id);

            if (entityToReturn == null)
                return NotFound();

            return Ok(entityToReturn);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int top = 50)
        {
            var entitiesToReturn = await _DayListHandler.Get(top);

            if (entitiesToReturn == null)
                return NotFound();

            return Ok(entitiesToReturn);
        }

        [HttpPost("{studentsId}, {assistance}")]
        public async Task<IActionResult> Create([FromRoute] int studentsId, Assistance assistance)
        {
            try
            {
                DayListDto DayListDto = new DayListDto 
                { 
                    StudentsId = studentsId,
                    assistance = assistance
                };
                var entityToCreate = await _DayListHandler.Create(DayListDto);
                return Ok(entityToCreate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] DayListDto dto)
        {
            try
            {
                await _DayListHandler.Update(dto);
                return Ok(dto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _DayListHandler.Delete(id);
            return Ok();
        }
    }
}
