using HotelProjectWebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProjectWebUI.ViewComponents.Default
{
    public class _TeamPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TeamPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:38127/api/Staff/StaffList");
            if (responseMessage.IsSuccessStatusCode) 
            {
              var jsonData = await responseMessage.Content.ReadAsStringAsync();
              var values = JsonConvert.DeserializeObject<List<ResultStaffDto>>(jsonData);  
              var staff = values.Take(4).ToList();
              return View(staff);
            }
            return View();
        }
    }
}
