using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddBooking()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(string b)
        {
            return View(b);
        }
    }

}
