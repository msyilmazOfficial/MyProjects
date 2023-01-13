using Entities;

namespace DataAccess.Abstract
{
    public interface IPriceListRepository
    {
        Task<List<PriceList>> GetPriceList();

        Task<PriceList> GetPriceListById(int id);

        Task<PriceList> CreatePriceList(PriceList PriceList);

        Task<PriceList> UpdatePriceList(PriceList PriceList);

        Task DeletePriceList(int id);
    }
}
