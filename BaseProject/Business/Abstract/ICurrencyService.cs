using Entities;

namespace Business.Abstract
{
    public interface ICurrencyService
    {
        Task<List<Currency>> GetCurrency();

        Task<Currency> GetCurrencyById(int id);

        Task<Currency> CreateCurrency(Currency Currency);

        Task<Currency> UpdateCurrency(Currency Currency);

        Task DeleteCurrency(int id);
    }
}
