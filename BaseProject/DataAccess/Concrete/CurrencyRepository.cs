using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class CurrencyRepository : ICurrencyRepository
    {
        public async Task<Currency> CreateCurrency(Currency currency)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Currency.Add(currency);
                await dbContex.SaveChangesAsync();
                return currency;
            }
        }

        public async Task DeleteCurrency(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                Currency currency = await GetCurrencyById(id);
                dbContex.Currency.Remove(currency);
                await dbContex.SaveChangesAsync();
            }
        }

        public async Task<Currency> GetCurrencyById(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Currency.FindAsync(id);
            }
        }

        public async Task<List<Currency>> GetCurrency()
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Currency.ToListAsync();
            }
        }

        public async Task<Currency> UpdateCurrency(Currency currency)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Currency.Update(currency);
                await dbContex.SaveChangesAsync();
                return currency;
            }
        }
    }
}
