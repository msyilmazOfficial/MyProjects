using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService OrderService;

        public OrderController(IOrderService OrderService)
        {
            this.OrderService = OrderService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetOrder()
        {
            var Orders = await OrderService.GetOrder();
            return Ok(Orders);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var Order = await OrderService.GetOrderById(id);
            if (Order != null)
            {
                return Ok(Order);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateOrder(Order Order)
        {
            var createOrder = await OrderService.CreateOrder(Order);
            return CreatedAtAction("GetOrderById", new { id = Order.Id }, createOrder);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateOrder(Order Order)
        {
            if (OrderService.GetOrderById(Order.Id) != null)
            {
                return Ok(await OrderService.UpdateOrder(Order));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            if (await OrderService.GetOrderById(id) != null)
            {
                await OrderService.DeleteOrder(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
