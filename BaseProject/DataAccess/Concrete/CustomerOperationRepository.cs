using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class CustomerOperationRepository : ICustomerOperationRepository
    {
        public async Task<CustomerOperation> CreateCustomerOperation(CustomerOperation CustomerOperation)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.CustomerOperation.Add(CustomerOperation);
                await dbContex.SaveChangesAsync();
                return CustomerOperation;
            }
        }

        public async Task DeleteCustomerOperation(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                CustomerOperation CustomerOperation = await GetCustomerOperationById(id);
                dbContex.CustomerOperation.Remove(CustomerOperation);
                await dbContex.SaveChangesAsync();
            }
        }

        public async Task<CustomerOperation> GetCustomerOperationById(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.CustomerOperation.FindAsync(id);
            }
        }

        public async Task<List<CustomerOperation>> GetCustomerOperation()
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.CustomerOperation.ToListAsync();
            }
        }

        public async Task<CustomerOperation> UpdateCustomerOperation(CustomerOperation CustomerOperation)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.CustomerOperation.Update(CustomerOperation);
                await dbContex.SaveChangesAsync();
                return CustomerOperation;
            }
        }
    }
}
