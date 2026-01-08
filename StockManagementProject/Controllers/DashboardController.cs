using Microsoft.AspNetCore.Mvc;

namespace StockManagementProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult ViewDashboard()
        {
            return View();
        }
    }
}
