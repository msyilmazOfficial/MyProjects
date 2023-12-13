using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService CustomerService;

        public CustomerController(ICustomerService CustomerService)
        {
            this.CustomerService = CustomerService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetCustomer()
        {
            var Customers = await CustomerService.GetCustomer();
            return Ok(Customers);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var Customer = await CustomerService.GetCustomerById(id);
            if (Customer != null)
            {
                return Ok(Customer);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateCustomer(Customer Customer)
        {
            var createCustomer = await CustomerService.CreateCustomer(Customer);
            return CreatedAtAction("GetCustomerById", new { id = Customer.Id }, createCustomer);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateCustomer(Customer Customer)
        {
            if (CustomerService.GetCustomerById(Customer.Id) != null)
            {
                return Ok(await CustomerService.UpdateCustomer(Customer));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            if (await CustomerService.GetCustomerById(id) != null)
            {
                await CustomerService.DeleteCustomer(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
