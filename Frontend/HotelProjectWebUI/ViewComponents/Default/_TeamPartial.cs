using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebUI.ViewComponents.Default
{
    public class _TeamPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
