using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class CurrencyManager : ICurrencyService
    {
        private ICurrencyRepository _CurrencyRepository;

        public CurrencyManager(ICurrencyRepository CurrencyRepository)
        {
            _CurrencyRepository = CurrencyRepository;
        }

        public async Task<Currency> CreateCurrency(Currency Currency)
        {
            return await _CurrencyRepository.CreateCurrency(Currency);
        }

        public async Task DeleteCurrency(int id)
        {
            await _CurrencyRepository.DeleteCurrency(id);
        }

        public async Task<Currency> GetCurrencyById(int id)
        {
            return await _CurrencyRepository.GetCurrencyById(id);
        }

        public async Task<List<Currency>> GetCurrency()
        {
            return await _CurrencyRepository.GetCurrency();
        }

        public async Task<Currency> UpdateCurrency(Currency Currency)
        {
            return await _CurrencyRepository.UpdateCurrency(Currency);
        }
    }
}
