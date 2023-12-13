using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerRepository _CustomerRepository;

        public CustomerManager(ICustomerRepository CustomerRepository)
        {
            _CustomerRepository = CustomerRepository;
        }

        public async Task<Customer> CreateCustomer(Customer Customer)
        {
            return await _CustomerRepository.CreateCustomer(Customer);
        }

        public async Task DeleteCustomer(int id)
        {
            await _CustomerRepository.DeleteCustomer(id);
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _CustomerRepository.GetCustomerById(id);
        }

        public async Task<List<Customer>> GetCustomer()
        {
            return await _CustomerRepository.GetCustomer();
        }

        public async Task<Customer> UpdateCustomer(Customer Customer)
        {
            return await _CustomerRepository.UpdateCustomer(Customer);
        }
    }
}
