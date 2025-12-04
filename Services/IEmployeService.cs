using GesEmpAspNet.Models;

namespace GesEmpAspNet.Services
{
    public interface IEmployeService
    {
        Task<(IEnumerable<Employe> Items, int TotalPages)> GetEmployesPagedAsync(int page, int pageSize, int? departementId = null);
    }
}
