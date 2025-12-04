using Microsoft.AspNetCore.Mvc;

namespace GesEmpAspNet.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
