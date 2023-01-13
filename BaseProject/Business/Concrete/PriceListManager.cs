using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class PriceListManager : IPriceListService
    {
        private IPriceListRepository _PriceListRepository;

        public PriceListManager(IPriceListRepository PriceListRepository)
        {
            _PriceListRepository = PriceListRepository;
        }

        public async Task<PriceList> CreatePriceList(PriceList PriceList)
        {
            return await _PriceListRepository.CreatePriceList(PriceList);
        }

        public async Task DeletePriceList(int id)
        {
            await _PriceListRepository.DeletePriceList(id);
        }

        public async Task<PriceList> GetPriceListById(int id)
        {
            return await _PriceListRepository.GetPriceListById(id);
        }

        public async Task<List<PriceList>> GetPriceList()
        {
            return await _PriceListRepository.GetPriceList();
        }

        public async Task<PriceList> UpdatePriceList(PriceList PriceList)
        {
            return await _PriceListRepository.UpdatePriceList(PriceList);
        }
    }
}
