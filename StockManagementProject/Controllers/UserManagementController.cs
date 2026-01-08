using Microsoft.AspNetCore.Mvc;

namespace StockManagementProject.Controllers
{
    public class UserManagementController : Controller
    {
        public IActionResult UserManagement()
        {
            return View();
        }
    }
}
