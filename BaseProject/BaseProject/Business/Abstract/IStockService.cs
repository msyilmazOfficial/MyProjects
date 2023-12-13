using Entities;

namespace Business.Abstract
{
    public interface IStockService
    {
        Task<List<Stock>> GetStock();

        Task<Stock> GetStockById(int id);

        Task<Stock> CreateStock(Stock Stock);

        Task<Stock> UpdateStock(Stock Stock);

        Task DeleteStock(int id);
    }
}
