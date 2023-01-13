using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class StocOperationManager : IStocOperationService
    {
        private IStocOperationRepository _StocOperationRepository;

        public StocOperationManager(IStocOperationRepository StocOperationRepository)
        {
            _StocOperationRepository = StocOperationRepository;
        }

        public async Task<StocOperation> CreateStocOperation(StocOperation StocOperation)
        {
            return await _StocOperationRepository.CreateStocOperation(StocOperation);
        }

        public async Task DeleteStocOperation(int id)
        {
            await _StocOperationRepository.DeleteStocOperation(id);
        }

        public async Task<StocOperation> GetStocOperationById(int id)
        {
            return await _StocOperationRepository.GetStocOperationById(id);
        }

        public async Task<List<StocOperation>> GetStocOperation()
        {
            return await _StocOperationRepository.GetStocOperation();
        }

        public async Task<StocOperation> UpdateStocOperation(StocOperation StocOperation)
        {
            return await _StocOperationRepository.UpdateStocOperation(StocOperation);
        }
    }
}
