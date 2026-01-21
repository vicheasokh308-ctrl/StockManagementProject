using Microsoft.AspNetCore.Mvc;

namespace StockManagementProject.Controllers
{
    public class Reset_PasswordController : Controller
    {
        public IActionResult ViewReset_Password()
        {
            return View();
        }
    }
}
