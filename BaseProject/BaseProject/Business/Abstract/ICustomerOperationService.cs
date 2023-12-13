using Entities;

namespace Business.Abstract
{
    public interface ICustomerOperationService
    {
        Task<List<CustomerOperation>> GetCustomerOperation();

        Task<CustomerOperation> GetCustomerOperationById(int id);

        Task<CustomerOperation> CreateCustomerOperation(CustomerOperation CustomerOperation);

        Task<CustomerOperation> UpdateCustomerOperation(CustomerOperation CustomerOperation);

        Task DeleteCustomerOperation(int id);
    }
}
