using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class StocOperationController : ControllerBase
    {
        private readonly IStocOperationService StocOperationService;

        public StocOperationController(IStocOperationService StocOperationService)
        {
            this.StocOperationService = StocOperationService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetStocOperation()
        {
            var StocOperations = await StocOperationService.GetStocOperation();
            return Ok(StocOperations);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetStocOperationById(int id)
        {
            var StocOperation = await StocOperationService.GetStocOperationById(id);
            if (StocOperation != null)
            {
                return Ok(StocOperation);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateStocOperation(StocOperation StocOperation)
        {
            var createStocOperation = await StocOperationService.CreateStocOperation(StocOperation);
            return CreatedAtAction("GetStocOperationById", new { id = StocOperation.Id }, createStocOperation);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateStocOperation(StocOperation StocOperation)
        {
            if (StocOperationService.GetStocOperationById(StocOperation.Id) != null)
            {
                return Ok(await StocOperationService.UpdateStocOperation(StocOperation));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteStocOperation(int id)
        {
            if (await StocOperationService.GetStocOperationById(id) != null)
            {
                await StocOperationService.DeleteStocOperation(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
