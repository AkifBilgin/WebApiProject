using HotelProjectWebUI.Dtos.BookingDto;
using HotelProjectWebUI.Dtos.ContactCategoryDto;
using HotelProjectWebUI.Dtos.ContactDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:38127/api/MessageCategory");
            //if (responseMessage.IsSuccessStatusCode)
            //{
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                
                var values = JsonConvert.DeserializeObject<List<ResultMessageCategoryDto>>(JsonData);

                List<SelectListItem> selectListItems = (from x in values
                                                        select new SelectListItem
                                                        {
                                                            Text = x.MessageCategoryName,
                                                            Value =x.MessageCategoryID.ToString()
                                                        }).ToList();
            ViewBag.SelectListItems = selectListItems;
           // }

            
            return View();
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {
            createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());   
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:38127/api/Contact", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
