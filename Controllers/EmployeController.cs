using Microsoft.AspNetCore.Mvc;
using GesEmpAspNet.Services;

namespace GesEmpAspNet.Controllers
{
    public class EmployeController : Controller
    {
        private readonly IEmployeService _service;
        
        public EmployeController(IEmployeService service)
        {
            _service = service;
        }
        
        public async Task<IActionResult> Index(int page = 1, int? departementId = null)
        {
            const int pageSize = 10;
            var (employes, totalPages) = await _service.GetEmployesPagedAsync(page, pageSize, departementId);
            
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.DepartementId = departementId;
            
            return View(employes);
        }
    }
}
