using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class StockRepository : IStockRepository
    {
        public async Task<Stock> CreateStock(Stock Stock)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Stock.Add(Stock);
                await dbContex.SaveChangesAsync();
                return Stock;
            }
        }

        public async Task DeleteStock(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                Stock Stock = await GetStockById(id);
                dbContex.Stock.Remove(Stock);
                await dbContex.SaveChangesAsync();
            }
        }

        public async Task<Stock> GetStockById(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Stock.FindAsync(id);
            }
        }

        public async Task<List<Stock>> GetStock()
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Stock.ToListAsync();
            }
        }

        public async Task<Stock> UpdateStock(Stock Stock)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Stock.Update(Stock);
                await dbContex.SaveChangesAsync();
                return Stock;
            }
        }
    }
}
