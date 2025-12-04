using GesEmpAspNet.Models;

namespace GesEmpAspNet.Services
{
    public interface IDepartementService
    {
        Task<(IEnumerable<Departement> Items, int TotalPages)> GetDepartementsPagedAsync(int page, int pageSize);
        Task<Departement?> GetDepartementByIdAsync(int id);
    }
}
