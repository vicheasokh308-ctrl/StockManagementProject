using Microsoft.AspNetCore.Mvc;

namespace StockManagementProject.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult ViewInventory()
        {
            return View();
        }
    }
}
