using Entities;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomer();

        Task<Customer> GetCustomerById(int id);

        Task<Customer> CreateCustomer(Customer Customer);

        Task<Customer> UpdateCustomer(Customer Customer);

        Task DeleteCustomer(int id);
    }
}
