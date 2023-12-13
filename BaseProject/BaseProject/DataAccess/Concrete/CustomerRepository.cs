using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<Customer> CreateCustomer(Customer Customer)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Customer.Add(Customer);
                await dbContex.SaveChangesAsync();
                return Customer;
            }
        }

        public async Task DeleteCustomer(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                Customer Customer = await GetCustomerById(id);
                dbContex.Customer.Remove(Customer);
                await dbContex.SaveChangesAsync();
            }
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Customer.FindAsync(id);
            }
        }

        public async Task<List<Customer>> GetCustomer()
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Customer.ToListAsync();
            }
        }

        public async Task<Customer> UpdateCustomer(Customer Customer)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Customer.Update(Customer);
                await dbContex.SaveChangesAsync();
                return Customer;
            }
        }
    }
}
