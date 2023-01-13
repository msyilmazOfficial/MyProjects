using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class StockController : ControllerBase
    {
        private readonly IStockService StockService;

        public StockController(IStockService StockService)
        {
            this.StockService = StockService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetStock()
        {
            var Stocks = await StockService.GetStock();
            return Ok(Stocks);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetStockById(int id)
        {
            var Stock = await StockService.GetStockById(id);
            if (Stock != null)
            {
                return Ok(Stock);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateStock(Stock Stock)
        {
            var createStock = await StockService.CreateStock(Stock);
            return CreatedAtAction("GetStockById", new { id = Stock.Id }, createStock);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateStock(Stock Stock)
        {
            if (StockService.GetStockById(Stock.Id) != null)
            {
                return Ok(await StockService.UpdateStock(Stock));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteStock(int id)
        {
            if (await StockService.GetStockById(id) != null)
            {
                await StockService.DeleteStock(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
