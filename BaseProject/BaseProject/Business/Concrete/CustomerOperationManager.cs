using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class CustomerOperationManager : ICustomerOperationService
    {
        private ICustomerOperationRepository _CustomerOperationRepository;

        public CustomerOperationManager(ICustomerOperationRepository CustomerOperationRepository)
        {
            _CustomerOperationRepository = CustomerOperationRepository;
        }

        public async Task<CustomerOperation> CreateCustomerOperation(CustomerOperation CustomerOperation)
        {
            return await _CustomerOperationRepository.CreateCustomerOperation(CustomerOperation);
        }

        public async Task DeleteCustomerOperation(int id)
        {
            await _CustomerOperationRepository.DeleteCustomerOperation(id);
        }

        public async Task<CustomerOperation> GetCustomerOperationById(int id)
        {
            return await _CustomerOperationRepository.GetCustomerOperationById(id);
        }

        public async Task<List<CustomerOperation>> GetCustomerOperation()
        {
            return await _CustomerOperationRepository.GetCustomerOperation();
        }

        public async Task<CustomerOperation> UpdateCustomerOperation(CustomerOperation CustomerOperation)
        {
            return await _CustomerOperationRepository.UpdateCustomerOperation(CustomerOperation);
        }
    }
}
