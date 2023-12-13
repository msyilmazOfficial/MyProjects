using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class PriceListController : ControllerBase
    {
        private readonly IPriceListService PriceListService;

        public PriceListController(IPriceListService PriceListService)
        {
            this.PriceListService = PriceListService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetPriceList()
        {
            var PriceLists = await PriceListService.GetPriceList();
            return Ok(PriceLists);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetPriceListById(int id)
        {
            var PriceList = await PriceListService.GetPriceListById(id);
            if (PriceList != null)
            {
                return Ok(PriceList);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreatePriceList(PriceList PriceList)
        {
            var createPriceList = await PriceListService.CreatePriceList(PriceList);
            return CreatedAtAction("GetPriceListById", new { id = PriceList.Id }, createPriceList);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdatePriceList(PriceList PriceList)
        {
            if (PriceListService.GetPriceListById(PriceList.Id) != null)
            {
                return Ok(await PriceListService.UpdatePriceList(PriceList));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeletePriceList(int id)
        {
            if (await PriceListService.GetPriceListById(id) != null)
            {
                await PriceListService.DeletePriceList(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
