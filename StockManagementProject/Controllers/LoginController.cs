using Microsoft.AspNetCore.Mvc;

namespace StockManagementProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult ViewLogin()
        {
            return View();
        }
    }
}
