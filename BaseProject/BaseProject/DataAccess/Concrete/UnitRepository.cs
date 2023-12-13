using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class UnitRepository : IUnitRepository
    {
        public async Task<Unit> CreateUnit(Unit Unit)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Unit.Add(Unit);
                await dbContex.SaveChangesAsync();
                return Unit;
            }
        }

        public async Task DeleteUnit(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                Unit Unit = await GetUnitById(id);
                dbContex.Unit.Remove(Unit);
                await dbContex.SaveChangesAsync();
            }
        }

        public async Task<Unit> GetUnitById(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Unit.FindAsync(id);
            }
        }

        public async Task<List<Unit>> GetUnit()
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Unit.ToListAsync();
            }
        }

        public async Task<Unit> UpdateUnit(Unit Unit)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Unit.Update(Unit);
                await dbContex.SaveChangesAsync();
                return Unit;
            }
        }
    }
}
