using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class WareHouseManager : IWareHouseService
    {
        private IWareHouseRepository _WareHouseRepository;

        public WareHouseManager(IWareHouseRepository WareHouseRepository)
        {
            _WareHouseRepository = WareHouseRepository;
        }

        public async Task<WareHouse> CreateWareHouse(WareHouse WareHouse)
        {
            return await _WareHouseRepository.CreateWareHouse(WareHouse);
        }

        public async Task DeleteWareHouse(int id)
        {
            await _WareHouseRepository.DeleteWareHouse(id);
        }

        public async Task<WareHouse> GetWareHouseById(int id)
        {
            return await _WareHouseRepository.GetWareHouseById(id);
        }

        public async Task<List<WareHouse>> GetWareHouse()
        {
            return await _WareHouseRepository.GetWareHouse();
        }

        public async Task<WareHouse> UpdateWareHouse(WareHouse WareHouse)
        {
            return await _WareHouseRepository.UpdateWareHouse(WareHouse);
        }
    }
}
