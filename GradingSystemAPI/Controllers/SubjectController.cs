using GradingSystem.Application.Subject.Dto;
using GradingSystem.Application.Subject.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace GradingSystemAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectHandler _SubjectHandler;
        public SubjectController(ISubjectHandler SubjectHandler)
        {
            _SubjectHandler = SubjectHandler;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var entityToReturn = await _SubjectHandler.GetById(id);

            if (entityToReturn == null)
                return NotFound();

            return Ok(entityToReturn);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int top = 50)
        {
            var entitiesToReturn = await _SubjectHandler.Get(top);

            if (entitiesToReturn == null)
                return NotFound();

            return Ok(entitiesToReturn);
        }

        [HttpPost("{name}")]
        public async Task<IActionResult> Create([FromRoute] string name)
        {
            try
            {
                SubjectDto SubjectDto = new SubjectDto { Name = name };
                var entityToCreate = await _SubjectHandler.Create(SubjectDto);
                return Ok(entityToCreate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] SubjectDto dto)
        {
            try
            {
                await _SubjectHandler.Update(dto);
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
            await _SubjectHandler.Delete(id);
            return Ok();
        }
    }
}
