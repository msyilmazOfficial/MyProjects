using Entities;

namespace Business.Abstract
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrder();

        Task<Order> GetOrderById(int id);

        Task<Order> CreateOrder(Order Order);

        Task<Order> UpdateOrder(Order Order);

        Task DeleteOrder(int id);
    }
}
