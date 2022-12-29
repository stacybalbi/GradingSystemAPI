using GradingSystem.Application.Students.Dto;
using GradingSystem.Application.Students.Handlers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace GradingSystemAPI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsHandler _StudentsHandler;
        public StudentsController(IStudentsHandler StudentsHandler)
        {
            _StudentsHandler = StudentsHandler;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var entityToReturn = await _StudentsHandler.GetById(id);

            if (entityToReturn == null)
                return NotFound();

            return Ok(entityToReturn);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int top = 50)
        {
            var entitiesToReturn = await _StudentsHandler.Get(top);

            if (entitiesToReturn == null)
                return NotFound();

            return Ok(entitiesToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] StudentsDto dto)
        {
            try
            {
                var entityToCreate = await _StudentsHandler.Create(dto);
                return Ok(entityToCreate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] StudentsDto dto)
        {
            try
            {
                await _StudentsHandler.Update(dto);
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
            await _StudentsHandler.Delete(id);
            return Ok();
        }
    }
}
