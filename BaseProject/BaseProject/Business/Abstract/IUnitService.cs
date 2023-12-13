using Entities;

namespace Business.Abstract
{
    public interface IUnitService
    {
        Task<List<Unit>> GetUnit();

        Task<Unit> GetUnitById(int id);

        Task<Unit> CreateUnit(Unit Unit);

        Task<Unit> UpdateUnit(Unit Unit);

        Task DeleteUnit(int id);
    }
}
