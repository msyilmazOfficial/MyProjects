using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class UnitManager : IUnitService
    {
        private IUnitRepository _UnitRepository;

        public UnitManager(IUnitRepository UnitRepository)
        {
            _UnitRepository = UnitRepository;
        }

        public async Task<Unit> CreateUnit(Unit Unit)
        {
            return await _UnitRepository.CreateUnit(Unit);
        }

        public async Task DeleteUnit(int id)
        {
            await _UnitRepository.DeleteUnit(id);
        }

        public async Task<Unit> GetUnitById(int id)
        {
            return await _UnitRepository.GetUnitById(id);
        }

        public async Task<List<Unit>> GetUnit()
        {
            return await _UnitRepository.GetUnit();
        }

        public async Task<Unit> UpdateUnit(Unit Unit)
        {
            return await _UnitRepository.UpdateUnit(Unit);
        }
    }
}
