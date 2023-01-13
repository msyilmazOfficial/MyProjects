using Entities;

namespace Business.Abstract
{
    public interface IWareHouseService
    {
        Task<List<WareHouse>> GetWareHouse();

        Task<WareHouse> GetWareHouseById(int id);

        Task<WareHouse> CreateWareHouse(WareHouse WareHouse);

        Task<WareHouse> UpdateWareHouse(WareHouse WareHouse);

        Task DeleteWareHouse(int id);
    }
}
