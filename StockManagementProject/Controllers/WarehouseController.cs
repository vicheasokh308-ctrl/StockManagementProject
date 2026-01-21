using Microsoft.AspNetCore.Mvc;

namespace StockManagementProject.Controllers
{
    public class WarehouseController : Controller
    {
        public IActionResult ViewWarehouse()
        {
            return View();
        }
    }
}
