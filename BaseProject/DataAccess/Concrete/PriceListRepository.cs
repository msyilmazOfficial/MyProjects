using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class PriceListRepository : IPriceListRepository
    {
        public async Task<PriceList> CreatePriceList(PriceList PriceList)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.PriceList.Add(PriceList);
                await dbContex.SaveChangesAsync();
                return PriceList;
            }
        }

        public async Task DeletePriceList(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                PriceList PriceList = await GetPriceListById(id);
                dbContex.PriceList.Remove(PriceList);
                await dbContex.SaveChangesAsync();
            }
        }

        public async Task<PriceList> GetPriceListById(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.PriceList.FindAsync(id);
            }
        }

        public async Task<List<PriceList>> GetPriceList()
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.PriceList.ToListAsync();
            }
        }

        public async Task<PriceList> UpdatePriceList(PriceList PriceList)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.PriceList.Update(PriceList);
                await dbContex.SaveChangesAsync();
                return PriceList;
            }
        }
    }
}
