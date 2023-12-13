using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerOperationController : ControllerBase
    {
        private readonly ICustomerOperationService CustomerOperationService;

        public CustomerOperationController(ICustomerOperationService CustomerOperationService)
        {
            this.CustomerOperationService = CustomerOperationService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetCustomerOperation()
        {
            var CustomerOperations = await CustomerOperationService.GetCustomerOperation();
            return Ok(CustomerOperations);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetCustomerOperationById(int id)
        {
            var CustomerOperation = await CustomerOperationService.GetCustomerOperationById(id);
            if (CustomerOperation != null)
            {
                return Ok(CustomerOperation);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateCustomerOperation(CustomerOperation CustomerOperation)
        {
            var createCustomerOperation = await CustomerOperationService.CreateCustomerOperation(CustomerOperation);
            return CreatedAtAction("GetCustomerOperationById", new { id = CustomerOperation.Id }, createCustomerOperation);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateCustomerOperation(CustomerOperation CustomerOperation)
        {
            if (CustomerOperationService.GetCustomerOperationById(CustomerOperation.Id) != null)
            {
                return Ok(await CustomerOperationService.UpdateCustomerOperation(CustomerOperation));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteCustomerOperation(int id)
        {
            if (await CustomerOperationService.GetCustomerOperationById(id) != null)
            {
                await CustomerOperationService.DeleteCustomerOperation(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
