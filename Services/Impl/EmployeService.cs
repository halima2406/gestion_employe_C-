using Data;
using GesEmpAspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace GesEmpAspNet.Services.Impl
{
    public class EmployeService : IEmployeService
    {
        private readonly GesEmpDbContext _context;
        
        public EmployeService(GesEmpDbContext context)
        {
            _context = context;
        }
        
        public async Task<(IEnumerable<Employe> Items, int TotalPages)> GetEmployesPagedAsync(int page, int pageSize, int? departementId = null)
        {
            var query = _context.Employes.AsQueryable();
            
            if (departementId.HasValue)
            {
                query = query.Where(e => e.DepartementId == departementId.Value);
            }
            
            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
            
            var items = await query
                .OrderBy(e => e.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            
            return (items, totalPages);
        }
    }
}
