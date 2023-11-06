using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebUI.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
