using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebUI.ViewComponents.Default
{
    public class _HeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
