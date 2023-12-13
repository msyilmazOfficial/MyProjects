using Entities;

namespace DataAccess.Abstract
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetOrder();

        Task<Order> GetOrderById(int id);

        Task<Order> CreateOrder(Order Order);

        Task<Order> UpdateOrder(Order Order);

        Task DeleteOrder(int id);
    }
}
