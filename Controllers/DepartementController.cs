using Microsoft.AspNetCore.Mvc;
using GesEmpAspNet.Services;

namespace GesEmpAspNet.Controllers
{
    public class DepartementController : Controller
    {
        private readonly IDepartementService _service;
        
        public DepartementController(IDepartementService service)
        {
            _service = service;
        }
        
        public async Task<IActionResult> Index(int page = 1)
        {
            const int pageSize = 10;
            var (departements, totalPages) = await _service.GetDepartementsPagedAsync(page, pageSize);
            
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            
            return View(departements);
        }
    }
}
