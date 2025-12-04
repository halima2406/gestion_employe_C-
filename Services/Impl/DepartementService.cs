using Data;
using GesEmpAspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace GesEmpAspNet.Services.Impl
{
    public class DepartementService : IDepartementService
    {
        private readonly GesEmpDbContext _context;
        
        public DepartementService(GesEmpDbContext context)
        {
            _context = context;
        }
        
        public async Task<(IEnumerable<Departement> Items, int TotalPages)> GetDepartementsPagedAsync(int page, int pageSize)
        {
            var totalItems = await _context.Departements.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
            
            var items = await _context.Departements
                .OrderBy(d => d.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            
            return (items, totalPages);
        }
        
        public async Task<Departement?> GetDepartementByIdAsync(int id)
        {
            return await _context.Departements.FindAsync(id);
        }
    }
}
