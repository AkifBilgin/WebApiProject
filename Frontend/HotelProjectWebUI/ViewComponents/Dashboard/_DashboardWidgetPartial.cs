using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProjectWebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;


        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:38127/api/DashboardWidgets/GetStaffCount");
            var jsondData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.staffCount = jsondData;



            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:38127/api/DashboardWidgets/GetBookingCount");
            var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.bookingCount = jsondata2;

            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("http://localhost:38127/api/DashboardWidgets/GetSubscribeCount");
            var jsondata3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.subscribeCount = jsondata3;

            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("http://localhost:38127/api/DashboardWidgets/GetBookingsWithoutConfirmation");
            var jsondata4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.notConfirmedCount = jsondata4;


            return View();
        }
    }
}
