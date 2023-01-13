using Entities;

namespace DataAccess.Abstract
{
    public interface IStocOperationRepository
    {
        Task<List<StocOperation>> GetStocOperation();

        Task<StocOperation> GetStocOperationById(int id);

        Task<StocOperation> CreateStocOperation(StocOperation StocOperation);

        Task<StocOperation> UpdateStocOperation(StocOperation StocOperation);

        Task DeleteStocOperation(int id);
    }
}
