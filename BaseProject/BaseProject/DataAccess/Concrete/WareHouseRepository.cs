using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class WareHouseRepository : IWareHouseRepository
    {
        public async Task<WareHouse> CreateWareHouse(WareHouse WareHouse)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.WareHouse.Add(WareHouse);
                await dbContex.SaveChangesAsync();
                return WareHouse;
            }
        }

        public async Task DeleteWareHouse(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                WareHouse WareHouse = await GetWareHouseById(id);
                dbContex.WareHouse.Remove(WareHouse);
                await dbContex.SaveChangesAsync();
            }
        }

        public async Task<WareHouse> GetWareHouseById(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.WareHouse.FindAsync(id);
            }
        }

        public async Task<List<WareHouse>> GetWareHouse()
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.WareHouse.ToListAsync();
            }
        }

        public async Task<WareHouse> UpdateWareHouse(WareHouse WareHouse)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.WareHouse.Update(WareHouse);
                await dbContex.SaveChangesAsync();
                return WareHouse;
            }
        }
    }
}
