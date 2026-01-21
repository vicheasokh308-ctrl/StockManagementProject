using Microsoft.AspNetCore.Mvc;

namespace StockManagementProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ViewProduct()
        {
            return View();
        }
    }
}
