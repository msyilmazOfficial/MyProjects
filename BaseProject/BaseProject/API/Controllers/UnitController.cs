using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class UnitController : ControllerBase
    {
        private readonly IUnitService UnitService;

        public UnitController(IUnitService UnitService)
        {
            this.UnitService = UnitService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetUnit()
        {
            var Units = await UnitService.GetUnit();
            return Ok(Units);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetUnitById(int id)
        {
            var Unit = await UnitService.GetUnitById(id);
            if (Unit != null)
            {
                return Ok(Unit);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateUnit(Unit Unit)
        {
            var createUnit = await UnitService.CreateUnit(Unit);
            return CreatedAtAction("GetUnitById", new { id = Unit.Id }, createUnit);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateUnit(Unit Unit)
        {
            if (UnitService.GetUnitById(Unit.Id) != null)
            {
                return Ok(await UnitService.UpdateUnit(Unit));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteUnit(int id)
        {
            if (await UnitService.GetUnitById(id) != null)
            {
                await UnitService.DeleteUnit(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
