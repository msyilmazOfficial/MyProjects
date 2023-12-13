using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class WareHouseController : ControllerBase
    {
        private readonly IWareHouseService WareHouseService;

        public WareHouseController(IWareHouseService WareHouseService)
        {
            this.WareHouseService = WareHouseService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetWareHouse()
        {
            var WareHouses = await WareHouseService.GetWareHouse();
            return Ok(WareHouses);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetWareHouseById(int id)
        {
            var WareHouse = await WareHouseService.GetWareHouseById(id);
            if (WareHouse != null)
            {
                return Ok(WareHouse);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateWareHouse(WareHouse WareHouse)
        {
            var createWareHouse = await WareHouseService.CreateWareHouse(WareHouse);
            return CreatedAtAction("GetWareHouseById", new { id = WareHouse.Id }, createWareHouse);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateWareHouse(WareHouse WareHouse)
        {
            if (WareHouseService.GetWareHouseById(WareHouse.Id) != null)
            {
                return Ok(await WareHouseService.UpdateWareHouse(WareHouse));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteWareHouse(int id)
        {
            if (await WareHouseService.GetWareHouseById(id) != null)
            {
                await WareHouseService.DeleteWareHouse(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
