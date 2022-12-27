using GradingSystem.Application.Score.Dto;
using GradingSystem.Application.Score.Handlers;
using GradingSystem.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace GradingSystemAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private readonly IScoreHandler _ScoreHandler;
        public ScoreController(IScoreHandler ScoreHandler)
        {
            _ScoreHandler = ScoreHandler;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var entityToReturn = await _ScoreHandler.GetById(id);

            if (entityToReturn == null)
                return NotFound();

            return Ok(entityToReturn);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int top = 50)
        {
            var entitiesToReturn = await _ScoreHandler.Get(top);

            if (entitiesToReturn == null)
                return NotFound();

            return Ok(entitiesToReturn);
        }

        [HttpPost("{studentsId},{subjectId},{rating}")]
        public async Task<IActionResult> Create([FromRoute] int studentsId, int subjectId, int rating)
        {

            try
            {
                ScoreDto ScoreDto = new ScoreDto 
                { 
                    StudentsId = studentsId,
                    SubjectId = subjectId,
                    rating = rating
                
                };
                var entityToCreate = await _ScoreHandler.Create(ScoreDto);
                return Ok(entityToCreate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ScoreDto dto)
        {
            try
            {
                await _ScoreHandler.Update(dto);
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
            await _ScoreHandler.Delete(id);
            return Ok();
        }
    }
}
