using Entities;

namespace DataAccess.Abstract
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomer();

        Task<Customer> GetCustomerById(int id);

        Task<Customer> CreateCustomer(Customer customer);

        Task<Customer> UpdateCustomer(Customer customer);

        Task DeleteCustomer(int id);
    }
}
