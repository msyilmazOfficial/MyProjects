using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class StockManager : IStockService
    {
        private IStockRepository _StockRepository;

        public StockManager(IStockRepository StockRepository)
        {
            _StockRepository = StockRepository;
        }

        public async Task<Stock> CreateStock(Stock Stock)
        {
            return await _StockRepository.CreateStock(Stock);
        }

        public async Task DeleteStock(int id)
        {
            await _StockRepository.DeleteStock(id);
        }

        public async Task<Stock> GetStockById(int id)
        {
            return await _StockRepository.GetStockById(id);
        }

        public async Task<List<Stock>> GetStock()
        {
            return await _StockRepository.GetStock();
        }

        public async Task<Stock> UpdateStock(Stock Stock)
        {
            return await _StockRepository.UpdateStock(Stock);
        }
    }
}
