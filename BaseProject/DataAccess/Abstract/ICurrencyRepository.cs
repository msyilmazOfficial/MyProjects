using Entities;

namespace DataAccess.Abstract
{
    public interface ICurrencyRepository
    {
        Task<List<Currency>> GetCurrency();

        Task<Currency> GetCurrencyById(int id);

        Task<Currency> CreateCurrency(Currency currency);

        Task<Currency> UpdateCurrency(Currency currency);

        Task DeleteCurrency(int id);
    }
}
