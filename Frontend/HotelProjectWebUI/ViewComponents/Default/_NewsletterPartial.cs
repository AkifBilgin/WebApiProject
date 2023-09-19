using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebUI.ViewComponents.Default
{
    public class _NewsletterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
