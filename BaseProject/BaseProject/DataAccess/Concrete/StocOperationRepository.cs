using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class StocOperationRepository : IStocOperationRepository
    {
        public async Task<StocOperation> CreateStocOperation(StocOperation StocOperation)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.StocOperation.Add(StocOperation);
                await dbContex.SaveChangesAsync();
                return StocOperation;
            }
        }

        public async Task DeleteStocOperation(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                StocOperation StocOperation = await GetStocOperationById(id);
                dbContex.StocOperation.Remove(StocOperation);
                await dbContex.SaveChangesAsync();
            }
        }

        public async Task<StocOperation> GetStocOperationById(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.StocOperation.FindAsync(id);
            }
        }

        public async Task<List<StocOperation>> GetStocOperation()
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.StocOperation.ToListAsync();
            }
        }

        public async Task<StocOperation> UpdateStocOperation(StocOperation StocOperation)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.StocOperation.Update(StocOperation);
                await dbContex.SaveChangesAsync();
                return StocOperation;
            }
        }
    }
}
