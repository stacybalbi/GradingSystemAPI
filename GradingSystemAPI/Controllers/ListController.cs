using GradingSystem.Application.List.Dto;
using GradingSystem.Application.List.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace GradingSystemAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly IListHandler _ListHandler;
        public ListController(IListHandler ListHandler)
        {
            _ListHandler = ListHandler;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var entityToReturn = await _ListHandler.GetById(id);

            if (entityToReturn == null)
                return NotFound();

            return Ok(entityToReturn);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int top = 50)
        {
            var entitiesToReturn = await _ListHandler.Get(top);

            if (entitiesToReturn == null)
                return NotFound();

            return Ok(entitiesToReturn);
        }

        [HttpPost("{name}, {daylistId}")]
        public async Task<IActionResult> Create([FromRoute] string name, int daylistId)
        {
            try
            {
                ListDto ListDto = new ListDto 
                { 
                    Name = name ,
                    daylistId = daylistId

                };
                var entityToCreate = await _ListHandler.Create(ListDto);
                return Ok(entityToCreate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ListDto dto)
        {
            try
            {
                await _ListHandler.Update(dto);
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
            await _ListHandler.Delete(id);
            return Ok();
        }
    }       
}
