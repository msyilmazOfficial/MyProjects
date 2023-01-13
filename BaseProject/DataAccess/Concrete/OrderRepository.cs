using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        public async Task<Order> CreateOrder(Order Order)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Order.Add(Order);
                await dbContex.SaveChangesAsync();
                return Order;
            }
        }

        public async Task DeleteOrder(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                Order Order = await GetOrderById(id);
                dbContex.Order.Remove(Order);
                await dbContex.SaveChangesAsync();
            }
        }

        public async Task<Order> GetOrderById(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Order.FindAsync(id);
            }
        }

        public async Task<List<Order>> GetOrder()
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Order.ToListAsync();
            }
        }

        public async Task<Order> UpdateOrder(Order Order)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Order.Update(Order);
                await dbContex.SaveChangesAsync();
                return Order;
            }
        }
    }
}
