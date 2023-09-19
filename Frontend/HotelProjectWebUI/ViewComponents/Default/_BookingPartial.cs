using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebUI.ViewComponents.Default
{
    public class _BookingPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
