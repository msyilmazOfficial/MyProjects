using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderRepository _OrderRepository;

        public OrderManager(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }

        public async Task<Order> CreateOrder(Order Order)
        {
            return await _OrderRepository.CreateOrder(Order);
        }

        public async Task DeleteOrder(int id)
        {
            await _OrderRepository.DeleteOrder(id);
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _OrderRepository.GetOrderById(id);
        }

        public async Task<List<Order>> GetOrder()
        {
            return await _OrderRepository.GetOrder();
        }

        public async Task<Order> UpdateOrder(Order Order)
        {
            return await _OrderRepository.UpdateOrder(Order);
        }
    }
}
